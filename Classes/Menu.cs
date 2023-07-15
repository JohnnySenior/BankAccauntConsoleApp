using System;

public class Menu
{
    public void start()
    {
        Console.WriteLine("--------------- MENU ---------------");
        Console.WriteLine("1. Balance");
        Console.WriteLine("2. Withdraw");
        Console.WriteLine("3. Deposit");
        Console.WriteLine("4. Transfer");
        Console.WriteLine("5. Exit");
        Console.WriteLine("------------------------------------");
    }

    public void ChooseAccaunt()
    {
        Console.WriteLine("You have two Bank Accaunt. Which one do you need ?");
        Console.WriteLine("1. bankAccaunt");
        Console.WriteLine("2. bankAccaunt1");
        Console.Write("Choose accaunt: ");
    }
}