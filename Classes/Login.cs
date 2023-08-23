using System;
using System.Xml.Linq;

namespace BankSystemApp.Classes;

public class Login
{
    private readonly CreateAccount _createAccount;
    public Login(CreateAccount createAccount)
    {
        _createAccount = createAccount;
    }
    public void UserLogin(string login, int password)
    {
        while (_createAccount.Name != login || _createAccount.Password != password)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Incorrect User name or Password. Please, try again.");
            Console.ResetColor();
        }
    }
}