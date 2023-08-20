using System;

namespace BankSystemApp.Classes.Classes;

public class CreateAccount
{
    private string name;
    private int password;
    public string Name { get; set; }
    public int Password { get; set; }

    public CreateAccount()
    {
        name = Name;
        password = Password;

        name = ValueManipulator.GetInputByMessageToDate("---------------Create account---------------\n\nName: ");
        password = ValueManipulator.GetInputByMessageToNumbers("Password: ");

        Random random = new Random();
        ValueManipulator.ShowMessage($"\n{name}, verification successful." +
                                     $"\nYour Visa card has been successfully linked you." +
                                     $"\n\nCard number: {random.Next(100000000, 999999999)}" +
                                     $"\nName: {name}");
        int selection = ValueManipulator.GetInputByMessageToNumbers("\n1.Login\n2.Exit\nChoice:");
        if (selection == 1)
        {
        }
        else
            ValueManipulator.ShowMessage($"---------------Goodbye {name}!--------------- ");
    }
}