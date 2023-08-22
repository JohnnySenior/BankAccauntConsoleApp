using System;
using BankSystemApp.Classes.Classes;

namespace BankSystemApp.Classes
{
    class Program
    {
        static void Main()
        {
            int userPassword;
            
            Console.ForegroundColor = ConsoleColor.Magenta;
            int choiceLogin = ValueManipulator.GetInputByMessageToNumbers("---------------Bank Asia---------------" +
                                                                          "\n1.Create account\n2.Exit\nChoice: ");
            Console.ResetColor();

            switch (choiceLogin)
            {
                case 1:
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    string userName = ValueManipulator.GetInputByMessageToDate("---------------Create account---------------\nName: ");
                    userPassword = ValueManipulator.GetInputByMessageToNumbers("Password: ");
                    Console.ResetColor();
                    var createAccount = new CreateAccount(userName, userPassword);
                    createAccount.CreateNewUserAccount();
                    break;
                case 2:
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    ValueManipulator.ShowMessage($"---------------Goodbye!--------------- ");
                    break;
                default:
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    throw new Exception("There is no such choice.Try again!");
                    Console.ResetColor();
            }
        }
    }
}