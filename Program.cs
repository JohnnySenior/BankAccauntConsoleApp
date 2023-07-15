using System;

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
                Console.Write("Please enter a number that you need: ");
                number = int.Parse(Console.ReadLine());
                Console.Clear();

                switch (number)
                {
                    case 1:
                    key1: menu.ChooseAccaunt();
                    var accaunt = int.Parse(Console.ReadLine());

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
                            Console.WriteLine("You entered wrong number, try again !");
                            goto key1;
                        } break;

                    case 2:
                    key2: menu.ChooseAccaunt();
                        accaunt = int.Parse(Console.ReadLine());

                        if (accaunt == 1)
                        {
                            security.CheckPassword();
                            Console.Write("How much money you want to withdraw: ");
                            var withdraw = decimal.Parse(Console.ReadLine());
                            bankAccaunt.Withdaw(withdraw);
                        }
                        else if (accaunt == 2)
                        {
                            security.CheckPassword();
                            Console.Write("How much money you want to withdraw: ");
                            var withdraw = decimal.Parse(Console.ReadLine());
                            bankAccaunt1.Withdaw(withdraw);
                        }
                        else
                        {
                            Console.WriteLine("You entered wrong number, try again !");
                            goto key2;
                        } break;

                    case 3:
                    key3: menu.ChooseAccaunt();
                        accaunt = int.Parse(Console.ReadLine());

                        if (accaunt == 1)
                        {
                            Console.Write("How much money you want to deposit: ");
                            var deposit = decimal.Parse(Console.ReadLine());
                            bankAccaunt.Deposit(deposit); break;
                        }
                        else if (accaunt == 2)
                        {
                            Console.Write("How much money you want to deposit: ");
                            var deposit = decimal.Parse(Console.ReadLine());
                            bankAccaunt1.Deposit(deposit);
                        }
                        else
                        {
                            Console.WriteLine("You entered wrong number, try again !");
                            goto key3;
                        } break;

                    case 4:
                    key4: menu.ChooseAccaunt();
                        accaunt = int.Parse(Console.ReadLine());

                        if (accaunt == 1)
                        {
                            security.CheckPassword();
                            Console.Write("How much money you want to transfer: ");
                            var transfer = decimal.Parse(Console.ReadLine());
                            bankAccaunt.Transfer(bankAccaunt1, transfer);
                        }
                        if (accaunt == 2)
                        {
                            security.CheckPassword();
                            Console.Write("How much money you want to transfer: ");
                            var transfer = decimal.Parse(Console.ReadLine());
                            bankAccaunt1.Transfer(bankAccaunt, transfer);
                        }
                        else
                        {
                            Console.WriteLine("You entered wrong number, try again !");
                            goto key4;
                        } break;

                    case 5:
                        Console.WriteLine("Thank you for using!!!");
                        break;

                }
            } while (number != 5);
        }
    }
}