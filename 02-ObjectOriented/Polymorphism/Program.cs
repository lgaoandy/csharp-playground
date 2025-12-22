using System;
using System.Runtime.CompilerServices;
using InheritanceBanking;

class Program
{
    static void Main(string[] args)
    {
        // Testing bank account assignment
        BankAccount account1 = new BankAccount(100);
        account1.CalculateTransaction(50);
        account1.CalculateTransaction(50);

        Console.WriteLine();

        SavingsAccount saving1 = new SavingsAccount(1000);
        saving1.CalculateTransaction(50);
        saving1.CalculateTransaction(1000);
        saving1.CalculateTransaction(150);
        saving1.CalculateTransaction(100);
        saving1.CalculateTransaction(78.90);
    }
}
