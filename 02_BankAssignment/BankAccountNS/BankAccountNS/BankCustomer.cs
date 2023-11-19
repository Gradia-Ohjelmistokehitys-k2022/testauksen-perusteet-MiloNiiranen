using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountNS
{
    public class BankCustomer
    {
        private readonly string m_customerName;
        public static List<BankAccount> m_Accounts;

        public BankCustomer(string customerName)
        {
            m_customerName = customerName;
        }

        public string CustomerName
        {
            get { return m_customerName; }
        }

        public BankAccount CreateBankAccount()
        {
            BankAccount newBankAccount = new BankAccount();
            m_Accounts.Add(newBankAccount);
            return newBankAccount;
        }

        public static void DeleteBankAccount(int accountNumber)
        {
            m_Accounts.RemoveAll(account => account.AccountNumber == accountNumber);
        }
    }
}
