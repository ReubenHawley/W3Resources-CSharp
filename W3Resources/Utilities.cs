using System.ComponentModel;
using System.Reflection;

namespace W3Resources;

public static class Utilities
{
    /// <summary>
    /// Captures user input into variable using keyInfo and returns a * in order to mask the password input
    /// </summary>
    /// <returns></returns>
    public static string getpassword()
    {
        String pass = String.Empty;
        ConsoleKey key;
        do
        {
            // override the keypresses and capture it in variable key
            var keyInfo = Console.ReadKey(intercept: true);
            key = keyInfo.Key;
            //check if the person has pressed backspace and check if the length of typed password is > 0
            if (key == ConsoleKey.Backspace && pass.Length > 0)
            {
                //remove characters
                Console.Write("\b \b");
                pass = pass[0..^1];
            }
            else if (!char.IsControl(keyInfo.KeyChar))
            {
                Console.Write("*");
                pass += keyInfo.KeyChar;
            }
        } while (key != ConsoleKey.Enter);

        Console.WriteLine("\n");
        return pass;
    }
    
}