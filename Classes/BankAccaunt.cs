using System;
public class BankAccaunt
{
    public BankAccaunt(int accauntNumber, decimal balance)
    {
        AccauntNumber = accauntNumber;
        Balance = balance;
    }

    public int AccauntNumber { get; set; }
    public decimal Balance { get; set; }

    public void GetAccauntInfo()
    {
        Console.WriteLine($"Accaunt Number: {AccauntNumber}");
        Console.WriteLine($"Balance: {Balance}");
    }

    public void Deposit(decimal amount)
    {
        Balance += amount;
        Console.WriteLine($"{amount:C2} deposited to {AccauntNumber} Accaunt Number");
    }
    public void Withdaw(decimal amount)
    {
        if(Balance >= amount)
        {
            Balance -= amount;
            Console.WriteLine($"{amount:C2} withdraw from {AccauntNumber} Accaunt Number");
        }
        else
            Console.WriteLine("You do not have enough money, Please check your balance first!!!");
    }

    public void Transfer(BankAccaunt destinationAccaunt, decimal amount)
    {
        if(this.Balance >= amount)
        {
            this.Withdaw(amount);
            destinationAccaunt.Deposit(amount);
            Console.Write($"{amount:C2} transfered from {this.AccauntNumber}");
            Console.WriteLine($" to {destinationAccaunt.AccauntNumber} Accaunt Number");
        }
    }
}