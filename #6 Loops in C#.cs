using System;
using System.Buffers.Text;
using System.Collections.Generic;
using System.ComponentModel;
using System.Net.NetworkInformation;
using System.Runtime.Intrinsics.X86;
using System.Xml;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Loops
{
    class Program
    {
        static void Main()
        {
            //Console.WriteLine(1);
            //Console.WriteLine(2);
            //Console.WriteLine(3);
            //Console.WriteLine(4);
            //Console.WriteLine(5);

            //A loop allows us to:
            //1. Execute a block of code repeatedly
            //2. Based on a condition

            //FOR LOOP
            //for (int i = 1; i <= 5; i++)
            //{
            //    Console.WriteLine(i);
            //}

            //WHILE LOOP
            //int number = 10;

            //while (number <= 5)
            //{
            //    Console.WriteLine(number);
            //    number++;
            //}

            //DO - WHILE LOOP
            //int num = 10;

            //do
            //{
            //    Console.WriteLine(num);
            //}
            //while (num < 5);

            //FOREACH LOOP
            //int[] numbers = { 10, 20, 30, 40 };

            //foreach (int n in numbers)
            //{
            //    Console.WriteLine(n);
            //}

            //Quick Comparison
            //Loop      | Best Use 
            //--------  | -------------------------- 
            //for       | Fixed number of iterations 
            //while     | Condition - based looping 
            //do -while | At least one execution 
            //foreach   | Collections & arrays 

            //Common Mistakes
            //❌ Infinite loop
            //❌ Forgetting increment
            //❌ Using for instead of foreach
            //❌ Modifying collection inside foreach
        }
    }
}