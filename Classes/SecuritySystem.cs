using System;

public class SecuritySystem
{
    public string Password { get; set; }

    public void PasswordError()
    {
        Console.WriteLine("Password is wrong, check and try again");
        Console.WriteLine();
    }

    public void PasswordPassed()
    {
        Console.WriteLine("Password successfully passed !!!");
        Console.WriteLine();
    }

    public void CheckPassword()
    {
        key: Console.Write("Password:");
        var password = Console.ReadLine();
        Console.Clear();
        if (password != "password")
        {
            PasswordError();
            goto key;
        }
        PasswordPassed();
    }
}