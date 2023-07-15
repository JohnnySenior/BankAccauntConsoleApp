using System;

namespace BankSystemApp.Classes
{
    class Program
    {
        static void Main()
        {
            var menu = new Menu();
            var bankAccaunt = new BankAccaunt(500m);
            var bankAccaunt1 = new BankAccaunt(1000m);
            var security = new SecuritySystem();
            int number;
            bankAccaunt1.GetAccauntInfo();

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
                    key: Console.Write("Password:");
                        var password = Console.ReadLine();
                        Console.Clear();

                        if (password != "password")
                        {
                            security.PasswordError();
                            goto key;
                        }

                        security.PasswordPassed();
                        bankAccaunt.GetAccauntInfo();
                        break;
                    case 2:
                        Console.Write("Password: ");
                        password = Console.ReadLine();

                        if (password != "password")
                        {
                            security.PasswordError();
                            goto key;
                        }

                        security.PasswordPassed();
                        Console.Write("How much money you want to withdraw: ");
                        var withdraw = int.Parse(Console.ReadLine());
                        bankAccaunt.Withdaw(withdraw);
                        break;
                    case 3:
                        Console.Write("How much money you want to deposit: ");
                        var deposit = int.Parse(Console.ReadLine());
                        bankAccaunt.Deposit(deposit); break;
                    case 4: 
                        Console.WriteLine("Thank you for using!!!"); break;
                }
            } while(number != 4);
        }
    }
}