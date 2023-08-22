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
        ValueManipulator.ShowMessage($"\n{Name}, verification successful." +
                                     $"\nYour Visa card has been successfully linked you." +
                                     $"\n\nCard number: {cardNumber}" +
                                     $"\nName: {Name}");
        
        int selection = ValueManipulator.GetInputByMessageToNumbers("\n1.Login\n2.Exit\nChoice:");
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