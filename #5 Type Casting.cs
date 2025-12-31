using System;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.Metrics;
using System.Net.NetworkInformation;
using System.Runtime.InteropServices;

namespace TypeCastingExample
{
    class Program
    {
        static void Main()
        {
            //int a = 10;
            //double b = a; // int -> double

            //int marks = 85;
            //double result = marks;   // implicit: int -> double
            //Console.WriteLine(result); // 85

            //double price = 99.99;
            //int roundedDown = (int)price;   // explicit: double -> int
            //Console.WriteLine(roundedDown); // 99

            //long big = 3000000000;
            //checked
            //{
            //    int small = (int)big;
            //    Console.WriteLine(small);
            //}

            //(int)double vs Convert.ToInt32(double)
            //double x = 12.63;

            //Console.WriteLine((int)x);              // 12 (truncate)
            //Console.WriteLine(Convert.ToInt32(x));  // 13 (round)

            //string s = "123";
            //int n = int.Parse(s);
            //Console.WriteLine(n);

            //string s = "123a";
            //bool ok = int.TryParse(s, out int n);

            //Console.WriteLine(ok); // false
            //Console.WriteLine(n);  // 0

            //string s = "45";
            //int n = Convert.ToInt32(s);
            //Console.WriteLine(n);

            //object obj = "Hello C#";
            ////string text = (string)obj; // works if obj is actually a string
            ////string? text = obj as string;
            //if (obj is string text)
            //{
            //    Console.WriteLine(text);
            //}

            //Common Mistakes

            //1. Assuming(int)12.9 will round → it truncates. 
            //2. Using Parse on user input without validation → exceptions.
            //3. Ignoring overflow when converting large numbers → wrong results.
            //4. Casting reference types without checking → runtime exceptions.
        }
    }
}
