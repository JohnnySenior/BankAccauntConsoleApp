using System;
public class TransferAccount
{

    public TransferAccount(decimal balance)
    {
        Balance = balance;
    }
    private decimal Balance { get; set; }
    
    public void AccountBalance()
    {
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.WriteLine($"Balance: ${Balance}");
        Console.ResetColor();

    }

    public void Deposit(decimal amount)
    {
        Console.ForegroundColor = ConsoleColor.Magenta;
        Balance += amount;
        Console.WriteLine($"${amount} credited to the balance");
        Console.ResetColor();
    }

    public void WithDraw(decimal amount)
    {
        if (Balance >= amount)
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Balance -= amount;
            Console.WriteLine($"${amount} withdraw from account");
            Console.ResetColor();
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("You do not have enough money, Please check your balance first!");
            Console.ResetColor();
        }
    }
    // public void Transfer(BankAccount destinationAccount, decimal amount)
    // {
    //     if(this.Balance >= amount)
    //     {
    //         this.WithDraw(amount);
    //         destinationAccount.Deposit(amount);
    //         Console.Write($"{amount:C2} transfered from {this.AccauntNumber}");
    //         Console.WriteLine($" to {destinationAccount.AccauntNumber} Accaunt Number");
    //     }
    // }
}