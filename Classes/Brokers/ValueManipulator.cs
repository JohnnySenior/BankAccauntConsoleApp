using System;

namespace BankSystemApp.Classes.Classes;

public class ValueManipulator
{
    
    public static int InputOption()
    {
        int option = 0;
        try
        {
            option = int.Parse(Console.ReadLine());
            Console.Clear();
        }
        catch (FormatException formatException)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("The input is not in a correct format");
            Console.ResetColor();
        }
        catch (OverflowException overflowException)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Value is too large or too small, take a look data type.");
            Console.ResetColor();
        }
        catch (Exception exception)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(exception.Message);
            Console.ResetColor();
        }

        return option;
    }
    
    public static int GetInputByMessageToNumbers(string message)
    {
        Console.Write(message);
        int result;
        
        while (!Int32.TryParse(Console.ReadLine(), out result))
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("Invalid input. Please try again!");
            Console.ResetColor();
            Console.Write(message);
        }
        return result;
    }

    public static void ShowMessage(string message)
    { 
        Console.WriteLine(message);
    }

    public static string GetInputByMessageToDate(string message)
    {
        Console.Write(message);
        return Console.ReadLine();
    }
    
}