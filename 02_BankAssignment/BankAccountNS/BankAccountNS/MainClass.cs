using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountNS
{
    public class MainClass
    {
        static void Main()
        {
            BankAccount ba = new BankAccount(11.99);
            ba.Credit(5.77);
            ba.Debit(11.22);
            Console.WriteLine("Current balance is ${0}", ba.Balance);

            BankCustomer bc = new BankCustomer("Mr Mikey Mike");
        }
    }
}
