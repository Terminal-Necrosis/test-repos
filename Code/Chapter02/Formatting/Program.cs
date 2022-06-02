using System;
using static System.Console;

namespace Formatting
{
    class Program
    {
        static void Main(string[] args)
        {
            //int numberOfApples = 12;
            //decimal pricePerApple = 0.35M;
            //WriteLine(
            //    FormatException: "{0} apples cost {1:C}",
            //    arg0: numberOfApples,
            //    arg1: pricePerApple * numberOfApples);
            //string formatted = string.Format(
            //    format: "{0} apples costs {1:C}",
            //    arg0: numberOfApples,
            //    arg1: pricePerApple * numberOfApples);
            //WriteToFile(formatted); //writes the string into a file
            //WriteLine($"{numberOfApples} apples costs {pricePerApple * numberOfApples:C}");
            
            /*
            string applesText = "Apples";
            int applesCount = 1234;
            string bananasText = "Bananas";
            int bananasCount = 56789;
            int splitSupplies = bananasCount * 3;
            int sauceSupplies = applesCount * 3;
            WriteLine(
                format: "{0,-8} {1,6:N0} {2,6:N0}",
                arg0: "Name",
                arg1: "Count",
                arg2: "Ingredients");
            WriteLine(
                format: "{0,-8} {1,6:N0} {2,6:N0}",
                arg0: applesText,
                arg1: applesCount,
                arg2: sauceSupplies);
            WriteLine(
                format: "{0,-8} {1,6:N0} {2,6:N0}",
                arg0: bananasText,
                arg1: bananasCount,
                arg2: splitSupplies);
                */
                
                /*
                Write("Type your first name and press ENTER: ");
                string firstName = ReadLine();
                Write("Type your age and press ENTER: ");
                string age = ReadLine();
                WriteLine(
                    $"Hello {firstName}, you look good for {age}.");
                */
                Write("Press any key combination: ");
                ConsoleKeyInfo key = ReadKey();
                WriteLine();
                WriteLine("Key: {0}, Char: {1}, Modifiers: {2}",
                arg0: key.Key,
                arg1: key.KeyChar,
                arg2: key.Modifiers);
        }
    }
}
