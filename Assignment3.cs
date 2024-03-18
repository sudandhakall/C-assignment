//Author: Sudan Krishna Dhakal
//Std:C0901145

using System;


class Program
{
    static void Main(string[] args)
    {
        // Example usage of the BankAccount class
        BankAccount account1 = new BankAccount("123456789", "checking", 1000);
        account1.Deposit(500);
        account1.Withdraw(200);
        account1.GetAccountInfo();

        // You can create additional bank accounts and perform operations here.
    }
}


public class BankAccount
{
    // Properties
    public string AccountNumber { get; set; }
    public double Balance { get; private set; }
    public string AccountType { get; set; }

    /// <summary>
    /// Constructor to create a checking account with a specified account number.
    /// </summary>
    /// <param name="accountNumber">The account number.</param>
    public BankAccount(string accountNumber)
    {
        AccountNumber = accountNumber;
        Balance = 0.0;
        AccountType = "checking";
    }

    /// <summary>
    /// Constructor to create an account with a specified account number and type.
    /// </summary>
    /// <param name="accountNumber">The account number.</param>
    /// <param name="accountType">The type of the account (e.g., 'checking', 'savings').</param>
    public BankAccount(string accountNumber, string accountType)
    {
        AccountNumber = accountNumber;
        Balance = 0.0;
        AccountType = accountType;
    }

    /// <summary>
    /// Constructor to create an account with a specified account number, type, and initial balance.
    /// </summary>
    /// <param name="accountNumber">The account number.</param>
    /// <param name="accountType">The type of the account.</param>
    /// <param name="initialBalance">The initial balance of the account.</param>
    public BankAccount(string accountNumber, string accountType, double initialBalance)
    {
        AccountNumber = accountNumber;
        Balance = initialBalance;
        AccountType = accountType;
    }

    /// <summary>
    /// Method to deposit an amount into the account.
    /// </summary>
    /// <param name="amount">The amount to deposit.</param>
    public void Deposit(double amount)
    {
        if (amount > 0)
        {
            Balance += amount;
            Console.WriteLine($"Deposited ${amount}. New balance is ${Balance}.");
        }
        else
        {
            Console.WriteLine("Invalid amount. Please enter a positive number.");
        }
    }

    /// <summary>
    /// Method to withdraw an amount from the account.
    /// </summary>
    /// <param name="amount">The amount to withdraw.</param>
    public void Withdraw(double amount)
    {
        if (amount > 0 && amount <= Balance)
        {
            Balance -= amount;
            Console.WriteLine($"Withdrew ${amount}. New balance is ${Balance}.");
        }
        else if (amount > Balance)
        {
            Console.WriteLine("Insufficient funds.");
        }
        else
        {
            Console.WriteLine("Invalid amount. Please enter a positive number.");
        }
    }

    /// <summary>
    /// Method to display information about the account.
    /// </summary>
    public void GetAccountInfo()
    {
        Console.WriteLine($"Account Number: {AccountNumber}, Type: {AccountType}, Balance: ${Balance}");
    }
}
