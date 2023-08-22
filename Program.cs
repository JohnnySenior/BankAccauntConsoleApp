using System;
using BankSystemApp.Classes.Classes;

namespace BankSystemApp.Classes
{
    class Program
    {
        static void Main()
        {
            var bankAccaunt = new BankAccaunt(1, 500m);
            var bankAccaunt1 = new BankAccaunt(2, 1000m);
            var security = new SecuritySystem();
            int number;
            
            int choiceLogin = ValueManipulator.GetInputByMessageToNumbers("---------------Easy Transfer---------------" +
                                                                          "\n1.Create account\n2.Exit\nChoice: ");
            
            switch (choiceLogin)
            {

                case 1:
                    string userName = ValueManipulator.GetInputByMessageToDate("---------------Create account---------------\n\nName: ");
                    int userPassword = ValueManipulator.GetInputByMessageToNumbers("Password: ");
                    var createAccount = new CreateAccount(userName, userPassword);
                    createAccount.CreateNewUserAccount();
                    break;


                case 2:
                    ValueManipulator.ShowMessage($"---------------Goodbye!--------------- ");
                    break;

                default
                    : throw new Exception("We have only two operation!!! Check again.");
            }
            do
            {
                Console.WriteLine();
                Menu.start();
                number = ValueManipulator.GetInputByMessageToNumbers("Please enter a number that you need: ");
                Console.Clear();

                switch (number)
                {
                    case 1:
                    key1: Menu.ChooseAccaunt();
                    var accaunt = ValueManipulator.InputOption();

                        if (accaunt == 1)
                        {
                            security.CheckPassword();
                            bankAccaunt.GetAccauntInfo();
                        }
                        else if (accaunt == 2)
                        {
                            security.CheckPassword();
                            bankAccaunt1.GetAccauntInfo();
                        }
                        else
                        {
                            ValueManipulator.ShowMessage("You entered wrong number, try again !");
                            goto key1;
                        } break;

                    case 2:
                    key2: Menu.ChooseAccaunt();
                    accaunt = ValueManipulator.InputOption();

                        if (accaunt == 1)
                        {
                            security.CheckPassword();
                            var withdraw =
                                ValueManipulator.GetInputByMessageToNumbers("How much money you want to withdraw: ");
                            bankAccaunt.Withdaw(withdraw);
                        }
                        else if (accaunt == 2)
                        {
                            security.CheckPassword();
                            var withdraw = ValueManipulator.GetInputByMessageToNumbers("How much money you want to withdraw: ");
                            bankAccaunt1.Withdaw(withdraw);
                        }
                        else
                        {
                            ValueManipulator.ShowMessage("You entered wrong number, try again !");
                            goto key2;
                        } break;

                    case 3:
                    key3: Menu.ChooseAccaunt();
                        accaunt = int.Parse(Console.ReadLine());

                        if (accaunt == 1)
                        {
                            var deposit =
                                ValueManipulator.GetInputByMessageToNumbers("How much money you want to deposit: ");
                            bankAccaunt.Deposit(deposit); break;
                        }
                        else if (accaunt == 2)
                        {
                            var deposit =
                                ValueManipulator.GetInputByMessageToNumbers("How much money you want to deposit: ");
                            bankAccaunt1.Deposit(deposit);
                        }
                        else
                        {
                            ValueManipulator.ShowMessage("You entered wrong number, try again !");
                            goto key3;
                        } break;

                    case 4:
                    key4: Menu.ChooseAccaunt();
                    accaunt = ValueManipulator.InputOption();

                        if (accaunt == 1)
                        {
                            security.CheckPassword();
                            var transfer =
                                ValueManipulator.GetInputByMessageToNumbers("How much money you want to transfer: ");
                            bankAccaunt.Transfer(bankAccaunt1, transfer);
                        }
                        if (accaunt == 2)
                        {
                            security.CheckPassword();
                            var transfer =
                                ValueManipulator.GetInputByMessageToNumbers("How much money you want to transfer: ");
                            bankAccaunt1.Transfer(bankAccaunt, transfer);
                        }
                        else
                        {
                            ValueManipulator.ShowMessage("You entered wrong number, try again !");
                            goto key4;
                        } break;

                    case 5:
                        ValueManipulator.ShowMessage("Thank you for using!!!");
                        break;

                }
            } while (number != 5);
        }
    }
}