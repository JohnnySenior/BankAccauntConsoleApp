using System;
using BankSystemApp.Classes;

public class MainOperation
{
    private readonly CreateAccount _createAccount;
    public MainOperation(CreateAccount createAccount)
    {
        Balance = 500;
        _createAccount = createAccount;
    }
    private decimal Balance { get; set; }
    
    public void GetCurrentBalance()
    {
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.WriteLine($"Balance: ${Balance}");
        Console.ResetColor();

    }

    public void Deposit(decimal amount)
    {
        Console.ForegroundColor = ConsoleColor.Magenta;
        Balance += amount;
        Console.WriteLine($"${amount} deposited to the balance");
        Console.ResetColor();
    }

    public void WithDraw(decimal amount)
    {
        if (Balance >= amount)
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Balance -= amount;
            Console.WriteLine($"${amount} withdrawed from account");
            Console.ResetColor();
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("You do not have enough money, Please check your balance first!");
            Console.ResetColor();
        }
    }
    public void Transfer()
    {
        int iteration = 0;
        Console.WriteLine("Favorite accounts:");
        Random random = new Random();
        int cardNumber1 = random.Next(100000000, 999999999);
        int cardNumber2 = random.Next(100000000, 999999999);
        int cardNumber3 = random.Next(100000000, 999999999);
        int cardNumber4 = random.Next(100000000, 999999999);
        int cardNumber5 = random.Next(100000000, 999999999);

        List<AccountsForTransfer> listOfAccaunts = new List<AccountsForTransfer>();
        listOfAccaunts.Add(new("Johnny", cardNumber1));
        listOfAccaunts.Add(new("Zafar", cardNumber2));
        listOfAccaunts.Add(new("Jasurbek", cardNumber3));
        listOfAccaunts.Add(new("Elbek", cardNumber4));
        listOfAccaunts.Add(new("Shexrozbek", cardNumber5));

        foreach (var item in listOfAccaunts)
        {
            Console.WriteLine($"{++iteration}. {item}");
        }

        int account = ValueManipulator.GetInputByMessageToNumbers("Choose account which is inside favorites: ");
        Console.Clear();
        decimal transfer = ValueManipulator.GetInputByMessageToNumbers("How much money do you want to transfer: ");
        Console.Clear();

        if (this.Balance >= transfer)
        {
            this.Balance -= transfer; ;
            Console.Write($"${transfer} transfered from your card (number): {_createAccount.CardNumber}");
        }
    }

    
}