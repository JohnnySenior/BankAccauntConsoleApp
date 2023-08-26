using System;
using BankSystemApp.Classes;

public class Menu
{
    public void ChoiceOptionsOfMenu(CreateAccount createAccaunt)
    {
        int option;
        var mainOperation = new MainOperation(createAccaunt);
        var security = new SecuritySystem(createAccaunt);

    var report = new Report();
        do
        {
            report.ShowMenu();

            option = ValueManipulator.GetInputByMessageToNumbers("Please enter a number that you need: ");
            Console.Clear();

            switch (option)
            {
                case 1:
                    security.CheckPassword();
                    mainOperation.GetCurrentBalance();
                    break;
                case 2:
                    security.CheckPassword();
                    decimal withDraw =
                        ValueManipulator.GetInputByMessageToNumbers("How much money do you want to withdraw: ");
                    mainOperation.WithDraw(withDraw);
                    break;

                case 3:
                    security.CheckPassword();
                    decimal deposit =
                        ValueManipulator.GetInputByMessageToNumbers("How much money do you want to deposit: ");
                    mainOperation.Deposit(deposit); break;

                case 4:
                    security.CheckPassword();
                    mainOperation.Transfer();
                    break;

                case 5:
                    ValueManipulator.ShowMessage("Thank you for using!!!");
                    break;
            }
        } while (option != 5);
    }
}