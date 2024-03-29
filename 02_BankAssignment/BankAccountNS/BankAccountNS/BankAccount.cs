﻿namespace BankAccountNS
{
    public class BankAccount
    {
        
        private double m_balance;
        public const string DebitAmountExceedsBalanceMessage = "Debit amount exceeds balance";
        public const string DebitAmountLessThanZeroMessage = "Debit amount is less than zero";
        public const string CreditAmountLessThanZeroMessage = "Credit amount is less than zero";
        public int AccountNumber { get; private set; }
        private static int nextAccountNumber = 1;

        public BankAccount() 
        { 
            AccountNumber = nextAccountNumber;
            nextAccountNumber++;
        }

        public BankAccount(double balance)
        {
            m_balance = balance;
        }


        public double Balance
        {
            get { return m_balance; }
        }

        public void Debit(double amount)
        {
            if (amount > m_balance)
            {
                throw new ArgumentOutOfRangeException("amount", amount, DebitAmountExceedsBalanceMessage);
            }

            if (amount < 0)
            {
                throw new ArgumentOutOfRangeException("amount", amount, DebitAmountExceedsBalanceMessage);
            }

            m_balance -= amount;
        }

        public void Credit(double amount)
        {
            if (amount < 0)
            {
                throw new ArgumentOutOfRangeException("amount", amount, CreditAmountLessThanZeroMessage);
            }

            m_balance += amount;
        }

        public static void TransferToAccount(double amount, BankAccount senderAccount, BankAccount destinationAccount)
        {
            if (senderAccount.Balance < amount)
            {
                throw new InvalidOperationException("Insufficient funds for the transfer.");
            }

            senderAccount.Debit(amount);
            destinationAccount.Credit(amount);
        }
    }
}