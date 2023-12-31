using System;
using BankSystemApp.Classes.Interfaces;

namespace BankSystemApp.Classes;

public class Report : IReport
{
    public void ShowMenu()
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

    public void ReportProgress()
    {
        Console.ForegroundColor = ConsoleColor.Blue;
        ValueManipulator.ShowMessage("\nLoading...");
        Console.ResetColor();
    }

    public void Exit()
    {
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.WriteLine("---------------Goodbye!--------------- ");
        Console.ResetColor();
    }

    public void DefaultCase()
    {
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.WriteLine("There is no such choice.Try again!");
        Console.ResetColor();
    }
}