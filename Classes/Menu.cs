using System;
using BankSystemApp.Classes.Classes;

public class Menu
{
    private int UserBalance { get; set; }
    public void ChoiceOptionsOfMenu()
    {
        int sectionSelection;
        UserBalance = 100;
        var transferAccount = new TransferAccount(UserBalance);
            do
            {
                Report.ShowMenu();
                
                sectionSelection = ValueManipulator.GetInputByMessageToNumbers("Please enter a number that you need: ");
                Console.Clear();

                switch (sectionSelection)
                {
                    case 1:
                        var security = new SecuritySystem();
                        transferAccount.AccountBalance();
                        break;
                    case 2:
                        key2:
                        security = new SecuritySystem();
                    var withDraw =
                                ValueManipulator.GetInputByMessageToNumbers("How much money you want to withdraw: ");
                        transferAccount.WithDraw(withDraw);
                        break;
                    
                    case 3:
                        key3:
                        security = new SecuritySystem();
                        var deposit =
                            ValueManipulator.GetInputByMessageToNumbers("How much money you want to deposit: ");
                        transferAccount.Deposit(deposit); break;

                    // case 4:
                    // key4: menu.ChooseAccaunt();
                    // accaunt = ValueManipulator.InputOption();
                    //
                    //     if (accaunt == 1)
                    //     {
                    //         security.CheckPassword();
                    //         var transfer =
                    //             ValueManipulator.GetInputByMessageToNumbers("How much money you want to transfer: ");
                    //         bankAccaunt.Transfer(bankAccaunt1, transfer);
                    //     }
                    //     if (accaunt == 2)
                    //     {
                    //         security.CheckPassword();
                    //         var transfer =
                    //             ValueManipulator.GetInputByMessageToNumbers("How much money you want to transfer: ");
                    //         bankAccaunt1.Transfer(bankAccaunt, transfer);
                    //     }
                    //     else
                    //     {
                    //         ValueManipulator.ShowMessage("You entered wrong number, try again !");
                    //         goto key4;
                    //     } break;

                    case 5:
                        ValueManipulator.ShowMessage("Thank you for using!!!");
                        break;
                }
            } while (sectionSelection != 5);
    }
}