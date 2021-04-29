using System;
using System.Collections.Generic;
using System.Text;

namespace UnderstandingOOProject
{
    class Bank
    {
        void UndeerstandingOperatorOverloading()
        {
            Account account1 = new Account("1234", 10000, "Ramu");
            Account account2 = new Account("5678", 20000, "Somu");
            Account account3 = account1+account2;
            Console.WriteLine("Operator overloading");
            account1.PrintAccountDetails();
            account2.PrintAccountDetails();
            Console.WriteLine("----------------------");
            account3.PrintAccountDetails();
            Console.WriteLine("Printing the reference");
            Console.WriteLine(account1);

        }
        void CreateAndCheck()
        {
            Account account = new Account();
            account.OpenAccount(12345, "123-3453-253");
            account = null;
            Console.WriteLine(account.AccountNumber);
        }
        static void Main(string[] args)
        {
            Bank bank = new Bank();
            //bank.CreateAndCheck();
            //new Bank().CreateAndCheck(); //anonymous
            //Account account2 = new Account("0000090123", 12345.22, "Ramu");
            //Console.WriteLine("check");
            bank.UndeerstandingOperatorOverloading();            
        }
    }
}
