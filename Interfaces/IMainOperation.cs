namespace BankSystemApp.Classes.Interfaces;

public interface IMainOperation
{
    void GetCurrentBalance();
    void Deposit(decimal amount);
    void WithDraw(decimal amount);
    void Transfer();
}