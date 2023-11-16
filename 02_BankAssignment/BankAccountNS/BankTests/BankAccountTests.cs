using BankAccountNS;
using System.Security.Principal;

namespace BankTests
{
    [TestClass]
    public class BankAccountTests
    {
        [TestMethod]
        public void Debit_WithValidAmount_UpdatesBalance()
        {
            // Arrange
            double beginningBalance = 11.99;
            double debitAmount = 4.55;
            double expected = 7.44;
            BankAccount account = new BankAccount(beginningBalance);

            // Act
            account.Debit(debitAmount);

            // Assert
            double actual = account.Balance;
            Assert.AreEqual(expected, actual, 0.001, "Account not debited correctly");
        }

        [TestMethod]
        public void Debit_WhenAmountIsLessThanZero_ShouldThrowArgumentOutOfRange()
        {
            // Arrange
            double beginningBalance = 11.99;
            double debitAmount = -100.00;
            BankAccount account = new BankAccount(beginningBalance);

            // Act and assert
            Assert.ThrowsException<System.ArgumentOutOfRangeException>(() => account.Debit(debitAmount));
        }

        [TestMethod]
        public void Debit_WhenAmountIsMoreThanBalance_ShouldThrowArgumentOutOfRange()
        {
            // Arrange
            double beginningBalance = 11.99;
            double debitAmount = -20.0;
            BankAccount account = new BankAccount(beginningBalance);

            // Act
            try
            {
                account.Debit(debitAmount);
            }
            catch (System.ArgumentOutOfRangeException e)
            {
                // Assert
                StringAssert.Contains(e.Message, BankAccount.DebitAmountExceedsBalanceMessage);
                return;
            }
            Assert.Fail("The expected exception was not thrown.");
        }

        [TestMethod]
        public void Credit_WhenAmountIsLessThanZero_ShouldThrowArgumentOutOfRange()
        {
            // Arrange
            double beginningBalance = 11.99;
            double creditAmount = -100.0;
            BankAccount account = new BankAccount(beginningBalance);

            // Act
            try
            {
                account.Credit(creditAmount);
            }


            // Assert
            catch (System.ArgumentOutOfRangeException e)
            {
                StringAssert.Contains(e.Message, BankAccount.CreditAmountLessThanZeroMessage);
                return;
            }
            Assert.Fail("The expected exception was not thrown.");
        }

        [TestMethod]
        public void DeleteBankAccount_RemovesAccountFromList()
        {
            // Arrange
            BankCustomer.m_Accounts = new List<BankAccount>();

            BankCustomer customer = new BankCustomer("John Doe");
            BankAccount account1 = customer.CreateBankAccount();
            BankAccount account2 = customer.CreateBankAccount();
            BankAccount account3 = customer.CreateBankAccount();

            // Act
            BankCustomer.DeleteBankAccount(account2.AccountNumber);

            // Assert
            Assert.AreEqual(2, BankCustomer.m_Accounts.Count);
            Assert.IsFalse(BankCustomer.m_Accounts.Contains(account2));

        }

        [TestMethod]
        public void CreateBankAccount_AddsNewAccountToAccountsList()
        {
            // Arrange
            BankCustomer.m_Accounts = new List<BankAccount>();
            BankCustomer customer = new BankCustomer("John River");

            // Act
            BankAccount newAccount = customer.CreateBankAccount();

            // Assert
            Assert.IsNotNull(newAccount);
            CollectionAssert.Contains(BankCustomer.m_Accounts, newAccount);
        }
    }
}