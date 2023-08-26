namespace BankSystemApp.Classes
{
    class Program
    {
        static void Main()
        {
            var report = new Report();
            int userPassword;

            int loginOption = ValueManipulator.GetInputByMessageToNumbers("--------------- Easy Transfer App ---------------" +
                                                                          "\n1.Create account" +
                                                                          "\n2.Exit" +
                                                                          "\nChoice: ");
            Console.Clear();

            switch (loginOption)
            {
                case 1:
                    ValueManipulator.ShowMessage("--------------- Create Account ---------------");
                    string userName = ValueManipulator.GetInputByMessageToDate("Name: ");
                    userPassword = ValueManipulator.GetInputByMessageToNumbers("Password: ");

                    var createAccount = new CreateAccount(userName, userPassword);
                    createAccount.CreateNewUserAccount();

                    ValueManipulator.ShowMessage("--------------- Login ---------------");
                    int selection = ValueManipulator.GetInputByMessageToNumbers("1.Login\n2.Exit\nChoice:");

                    if (selection == 1)
                    {
                        var login = new Login(createAccount);
                        string name = ValueManipulator.GetInputByMessageToDate("User name:");
                        int password = ValueManipulator.GetInputByMessageToNumbers("Password:");
                        login.UserLogin(name, password);
                    }
                    else
                        ValueManipulator.ShowMessage($"---------------Goodbye {createAccount.Name}!--------------- ");

                    report.ReportProgress();

                    var menu = new Menu();
                    menu.ChoiceOptionsOfMenu(createAccount);
                    break;

                case 2:
                    report.Exit();
                    break;

                default:
                    while (!(loginOption == 1 || loginOption == 2))
                    {

                        Report.DefaultCase();
                        loginOption = ValueManipulator.GetInputByMessageToNumbers("--------------- Easy Transfer App ---------------" +

                                                                                    "\n1.Create account\n2.Exit\nChoice: ");
                    }
                    break;
            }
        }
    }
}