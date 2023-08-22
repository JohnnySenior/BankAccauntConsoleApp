using System;

namespace BankSystemApp.Classes.Classes;

public class Login
{ 
    public int CardNumber { get; set; }
    public int Password { get; set; }

    public Login(int readyCardNumber, int readyPassword)
    {
        CardNumber = readyCardNumber;
        Password = readyPassword;
    }
    
    public void UserLogin()
    {
        Console.WriteLine("---------------Login---------------");
        int cardNumber =
            ValueManipulator.GetInputByMessageToNumbers("Card Number: ");
        int password = ValueManipulator.GetInputByMessageToNumbers("Password: ");

        while (CardNumber != cardNumber || Password != password)
        {
            Console.Clear();
            Console.WriteLine("Incorrect card number or password.");
            cardNumber =
                ValueManipulator.GetInputByMessageToNumbers("Card Number: ");
            password = ValueManipulator.GetInputByMessageToNumbers("Password: ");
        }
        
        Console.WriteLine("Good");
    }
}