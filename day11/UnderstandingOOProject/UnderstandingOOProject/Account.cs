using System;
using System.Collections.Generic;
using System.Text;

namespace UnderstandingOOProject
{
    class Account
    {
        public string AccountNumber { get; set; }
        public double Balance { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public static Account operator +(Account account1,Account account2)
        {
            Account result = new Account();
            result.AccountNumber = account1.AccountNumber + "&" + account2.AccountNumber;
            result.Balance = account1.Balance + account2.Balance;
            result.Name = account1.Name + "and" + account2.Name;
            return result;
        }
        public Account()
        {
            AccountNumber = "0000000";
            Balance = 0.0;
            Name = "No one";
            Type = "Not sure yet";
        }
        public Account(string accountNumber,double balance,string name)
        {
            AccountNumber = accountNumber;
            Balance = balance;
            Name = name;
            Type = "Not sure yet";
        }
        public void OpenAccount()
        {
            Console.WriteLine("Go to bank and open the account");
        }
        public void OpenAccount(string panNumber)
        {
            Console.WriteLine("use the pan number {0} and open the account online",panNumber);
        }

        public void OpenAccount(string panNumber,double balance)
        {
            Balance = balance;
            Console.WriteLine("use the panNumber {0} and account online with balance{1}",panNumber,Balance);
        } 

        public void OpenAccount(double balance,string aadhar)
        {
            Balance = balance;
            Console.WriteLine("use the aadhar {0} and account online with balance{1}", aadhar, Balance);
        }
        public void PrintAccountDetails()
        {
            Console.WriteLine("AccountNumber:" + AccountNumber + "\nName of the Account: " +
                Name + "\nBalance: " + Balance);
        }
        public override string ToString()
        {
            return "AccountNumber:" + AccountNumber + "\nName of the Account: " +
                Name + "\nBalance: " + Balance;
        }

    }
}
