using System;

namespace BankSystemApp.Classes.Classes;

public class CreateAccount
{
    public string Name { get; set; }
    public int Password { get; set; }

    int cardNumber;

    public CreateAccount(string userName, int userPassword)
    {
        Name = userName;
        Password = userPassword;
    }
    
    public void CreateNewUserAccount()
    {
        Random random = new Random();
        cardNumber = random.Next(100000000, 999999999);
        
        Console.ForegroundColor = ConsoleColor.Green;
        ValueManipulator.ShowMessage($"\n{Name}, verification successful." +
                                     $"\nYour Visa card has been successfully linked you." +
                                     $"\n\nCard number: {cardNumber}" +
                                     $"\nName: {Name}");
        Console.ResetColor();

        Console.ForegroundColor = ConsoleColor.Blue;
        ValueManipulator.ShowMessage("---------------Section selection---------------");
        int selection = ValueManipulator.GetInputByMessageToNumbers("1.Login\n2.Exit\nChoice:");
        Console.ResetColor();
        if (selection == 1)
        {
            var login = new Login(Name, Password);
            login.UserLogin();
        }
        else
            ValueManipulator.ShowMessage($"---------------Goodbye {Name}!--------------- ");
        // return cardNumber;
    }
}