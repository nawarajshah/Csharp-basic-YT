using System;
using System.Net.NetworkInformation;
using System.Text;

namespace CsharpString
{
    class Program
    {
        static void Main()
        {
            // creating string in two different methods
            // first method
            //string first_name = "Nawaraj";

            // second method
            //string last_name = new string("Shah");
            //Console.WriteLine(first_name + "\n" + last_name);

            //string a = "Hello";
            //string b = "Hello";

            //Console.WriteLine(a + "\n" + b);

            // String is Immutable

            //string name = "Nawaraj";
            //name = name + " Shah";
            //Console.WriteLine(name);

            // String Comparison in C#
            // Using == operator
            //string a = "Hello";
            //string b = "Hello";
            //string c = new string("Hello");

            //Console.WriteLine(a == b);

            //Using Equals()
            //Console.WriteLine(a.Equals(b));

            //Console.WriteLine($"a == c: {a == c}");
            //Console.WriteLine($"ReferenceEquals(a, c): {object.ReferenceEquals(a, c)}");
            //Console.WriteLine($"ReferenceEquals(a, b): {object.ReferenceEquals(a, b)}");

            // Why StringBuilder Exists?

            //string result = "";

            //for (int i = 0; i <= 1000; i++)
            //{
            //    result = result + i;
            //}

            //StringBuilder sb = new StringBuilder();

            //for (int i = 0; i < 1000; i++)
            //{
            //    sb.Append(i);
            //}

            //string result = sb.ToString();

            //Commonly Used String Methods
            //string name = "Nepal";
            //Console.WriteLine(name.Length);
            //Console.WriteLine(name.ToUpper());
            //Console.WriteLine(name.ToLower());
            //Console.WriteLine(name.Contains("Na"));

            //string msg = "Hello World";
            //Console.WriteLine(msg.Replace("World", "Nepal"));

            string data = "Ram,Shyam,Hari";
            string[] names = data.Split(",");

            foreach(var n in names)
            {
                Console.WriteLine(n);
            }
        }
    }
}
/*
 * Hello
 * -------------
 * H
 * e
 * l
 * l
 * o
 */
