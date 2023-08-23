using System;

namespace BankSystemApp.Classes.Classes;

public class Report
{
    public static void ShowMenu()
    {
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("\n--------------- MENU ---------------");
        Console.WriteLine("1. Balance");
        Console.WriteLine("2. Withdraw");
        Console.WriteLine("3. Deposit");
        Console.WriteLine("4. Transfer");
        Console.WriteLine("5. Exit");
        Console.WriteLine("------------------------------------");
        Console.ResetColor();
    }

    public static void ReportProgress()
    {
        Console.ForegroundColor = ConsoleColor.Blue;
        ValueManipulator.ShowMessage("\nLoading...");
        Console.ResetColor();
    }
}