using System;

namespace BankSystemApp.Classes.Classes;

public class Login
{ 
    public string UserName { get; set; }
    public int Password { get; set; }

    public Login(string userName, int readyPassword)
    {
        UserName = userName;
        Password = readyPassword;
    }
    
    public void UserLogin()
    {
        Console.WriteLine("---------------Login---------------");
        string userName =
            ValueManipulator.GetInputByMessageToDate("User name: ");
        int password = ValueManipulator.GetInputByMessageToNumbers("Password: ");

        while (userName != userName || Password != password)
        {
            Console.Clear();
            Console.WriteLine("Incorrect User name or Password. Please, try again.");
            userName =
                ValueManipulator.GetInputByMessageToDate("User name: ");
            password = ValueManipulator.GetInputByMessageToNumbers("Password: ");
        }
        
        Console.WriteLine("Good");
    }
}