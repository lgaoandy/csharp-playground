using System.Drawing;

namespace InheritanceBanking;

public class BankAccount
{
    // Properties
    protected double Balance;
    protected double BaseTransactionFee = 5;

    // Constructor
    public BankAccount(double balance)
    {
        Balance = balance;
    }

    // Methods
    public virtual double CalculateTransaction(double requestAmount)
    {
        // Check if balance has enough for transaction
        if (Balance < BaseTransactionFee + requestAmount)
        {
            Console.WriteLine($"Not enough balance to process transaction.");
            return -1;
        }

        // Update balance
        Balance = Math.Round(Balance - BaseTransactionFee - requestAmount, 2);
        Console.WriteLine($"Withdrawed ${requestAmount}. Remaining Balance is ${Balance}.");
        return Balance;
    }
}

public class SavingsAccount : BankAccount
{
    private int WithdrawalCount;

    public SavingsAccount(double balance) : base(balance)
    {
        WithdrawalCount = 0;
    }

    // If withdraw count is greater than 3, adds 10% of the request amount
    public override double CalculateTransaction(double requestAmount)
    {
        if (WithdrawalCount < 3)
        {
            double result = base.CalculateTransaction(requestAmount);
            if (result != -1)
            {
                WithdrawalCount++;
            }
            return result;
        }

        // Check if balance has enough for the additional charge
        double transactionFee = Math.Round(0.1 * requestAmount, 2) + BaseTransactionFee;

        if (Balance < transactionFee + requestAmount)
        {
            Console.WriteLine($"Not enough balance to process transaction.");
            return -1;
        }

        // Commit changes and return remaining balance
        Balance = Math.Round(Balance - transactionFee - requestAmount, 2);
        WithdrawalCount++;
        Console.WriteLine($"Withdrawed ${requestAmount}. Remaining Balance is ${Balance}. Transaction Fee is ${transactionFee}");
        return Balance;
    }
}