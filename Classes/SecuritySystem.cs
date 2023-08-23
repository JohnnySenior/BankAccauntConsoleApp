using System;
using BankSystemApp.Classes.Classes;

public class SecuritySystem
{
    private int Password { get; set; }
    public SecuritySystem()
    {
        Password = 12345;
        Console.ForegroundColor = ConsoleColor.DarkCyan;
        int password = ValueManipulator.GetInputByMessageToNumbers("Your password[1-5?]\nEnter password: ");
        Console.ResetColor();
        Console.Clear();
        while (password != Password)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            ValueManipulator.ShowMessage("Password is wrong, check and try again.\n");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            password = ValueManipulator.GetInputByMessageToNumbers("Enter password: ");
            Console.ResetColor();
            Console.Clear();
        }
    }
}