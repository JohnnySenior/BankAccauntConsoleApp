using System;
using BankSystemApp.Classes.Classes;

namespace BankSystemApp.Classes
{
    class Program
    {
        static void Main()
        {
            var menu = new Menu();
            var bankAccaunt = new BankAccaunt(1, 500m);
            var bankAccaunt1 = new BankAccaunt(2, 1000m);
            var security = new SecuritySystem();
            int number;
            do
            {
                Console.WriteLine();
                menu.start();
                number = ValueManipulator.GetInputByMessageToNumbers("Please enter a number that you need: ");
                Console.Clear();

                switch (number)
                {
                    case 1:
                    key1: menu.ChooseAccaunt();
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
                    key2: menu.ChooseAccaunt();
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
                    key3: menu.ChooseAccaunt();
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
                    key4: menu.ChooseAccaunt();
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