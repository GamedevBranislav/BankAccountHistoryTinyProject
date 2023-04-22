using System;

namespace TestingBank
{
    class Program
    {
        //Run this to get BankAccountHistory 
        static void Main(string[] args)
        {
            var account = new BankAccount("Kendra", 10000);
            Console.WriteLine($"Account{account.Number} was created for {account.Owner} with {account.Balance}. ");


            account.MakeWitdrawal(120, DateTime.Now, "Expensive Dinner");

            account.MakeWitdrawal(335, DateTime.Now, "Ryanair Tickets");

            account.MakeWitdrawal(60, DateTime.Now, "Hogwarts Game");

            Console.WriteLine(account.GetAccountHistory());
            Console.WriteLine($"Actual balance is : {account.Balance} $");
        }
    }
}
