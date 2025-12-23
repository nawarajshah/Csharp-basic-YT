using System;

namespace MethodOfConsole
{
    class Program
    {
        static void Main()
        {
            Console.Title = "Console Class Demo";

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("=== Welcome ===");
            Console.ResetColor();

            Console.Write("Enter your name: ");
            string name = Console.ReadLine();

            Console.Write("Enter your age: ");
            string ageText = Console.ReadLine();

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"\nHello {name}, you are {ageText} years old!");
            Console.ResetColor();

            Console.WriteLine("\nPress any key to hear a beep...");
            Console.ReadKey(true);

            Console.Beep(900, 250);

            Console.WriteLine("\nDone. Press any key to exit.");
            Console.ReadKey();

        }

    }
    
}
