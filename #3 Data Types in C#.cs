using System;

namespace DataType
{
    class Program
    {
        static void Main()
        {
            // Integer types
            //int age = 25;
            //long population = 1400000000;
            //Console.WriteLine("Age: " + age);
            //Console.WriteLine("Population: " + population);

            // Floating-point types
            //float temperature = 36.6f;
            //double pi = 3.14159;
            //Console.WriteLine("Temperature: " + temperature);
            //Console.WriteLine("Pi: " + pi);

            // Character and string types
            //char grade = 'A';
            //string message = "Hello, World!";
            //Console.WriteLine("Grade: " + grade);
            //Console.WriteLine("Message: " + message);

            // Boolean type
            //bool isActive = true;
            //Console.WriteLine("Is Active: " + isActive);

            // Object type
            object value = 10;
            value = "Hello";
            value = true;

            Console.WriteLine("Object value: " + value);

            Console.ReadKey();
        }

    }

}
