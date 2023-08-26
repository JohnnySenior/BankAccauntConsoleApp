using System;
using BankSystemApp.Classes.Interfaces;

namespace BankSystemApp.Classes;

public class CreateAccount : ICreateAccount
{
    public string Name { get; set; }
    public int Password { get; set; }
    public int CardNumber { get; set; }

    public CreateAccount(string userName, int userPassword)
    {
        Name = userName;
        Password = userPassword;
    }

    public void CreateNewUserAccount()
    {
        Random random = new Random();
        CardNumber = random.Next(100000000, 999999999);

        Console.ForegroundColor = ConsoleColor.Green;
        ValueManipulator.ShowMessage($"\nHello {Name}, Your new accaunt successfully created." +
                                     $"\n\nCard number: {CardNumber}" +
                                     $"\nName: {Name}");
        Console.ResetColor();
    }
}