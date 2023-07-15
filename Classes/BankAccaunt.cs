using System;
public class BankAccaunt
{
    int accauntNumber = 0;
    public int AccauntNumber { get; set; }
    public decimal Balance { get; set; }
    public BankAccaunt(decimal balance)
    {
        AccauntNumber = ++accauntNumber;
        Balance = balance;
    }

    public void GetAccauntInfo()
    {
        Console.WriteLine($"Accaunt Number: {AccauntNumber}");
        Console.WriteLine($"Balance: {Balance}");
    }

    public decimal Deposit(decimal amount) =>
        Balance += amount;
    public void Withdaw(decimal amount)
    {
        if(Balance > amount)
            SubstructAmount(amount);
        else
            AmountError();
    }    
    public void AmountError() =>
        Console.WriteLine("You do not have enough money, Please check your balance first!!!");
    public decimal SubstructAmount(decimal amount) =>
        Balance -= amount;
}