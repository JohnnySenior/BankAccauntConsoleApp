using System;
using BankSystemApp.Classes;

public class SecuritySystem
{
    private readonly CreateAccount _createAccount;

    public SecuritySystem(CreateAccount createAccount)
    {
        _createAccount = createAccount;
    }

    public void CheckPassword()
    {
        Console.ForegroundColor = ConsoleColor.DarkCyan;
        int password = ValueManipulator.GetInputByMessageToNumbers("Enter password: ");
        Console.Clear();
        while (_createAccount.Password != password)
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