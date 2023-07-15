using System;

public class SecuritySystem
{
    public string Password { get; set; }

    public void CreatePasword(string password)
    {
        Password = password;
    }

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
}