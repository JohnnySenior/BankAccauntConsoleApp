using System;

namespace BankSystemApp.Classes;

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
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.Write(message);
        int result;
        Console.ResetColor();

        while (!int.TryParse(Console.ReadLine(), out result))
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("Invalid input. Please try again!");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Write(message);
            Console.ResetColor();
        }
        return result;
    }

    public static void ShowMessage(string message)
    {
        Console.WriteLine(message);
    }

    public static string GetInputByMessageToDate(string message)
    {
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.Write(message);
        Console.ResetColor();
        return Console.ReadLine();
    }

}