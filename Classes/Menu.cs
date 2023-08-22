using System;

public static class Menu
{
    public static void start()
    {
        Console.WriteLine("--------------- MENU ---------------");
        Console.WriteLine("1. Balance");
        Console.WriteLine("2. Withdraw");
        Console.WriteLine("3. Deposit");
        Console.WriteLine("4. Transfer");
        Console.WriteLine("5. Exit");
        Console.WriteLine("------------------------------------");
    }

    public static void ChooseAccaunt()
    {
        Console.WriteLine("You have two Bank Accaunt. Which one do you need ?");
        Console.WriteLine("1. bankAccaunt");
        Console.WriteLine("2. bankAccaunt1");
        Console.Write("Choose accaunt: ");
    }
}