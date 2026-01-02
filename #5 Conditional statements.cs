using System;
using System.Diagnostics;
using System.Linq.Expressions;
using System.Reflection.Metadata;
using System.Runtime.Intrinsics.X86;

namespace ConditionalStatement
{
    class Program
    {
        static void Main()
        {
            //We will cover:
            //* if statement
            //* if-else statement
            //* else if ladder
            //* switch statement
            //* Best practices with real-world examples

            //boolean expressions
            //* age >= 18
            //* marks >= 40
            //* isLoggedIn == true

            // IF STATEMENT
            //if (condition)
            //{
            //    // code executes if condition is true
            //}

            //int age = 20;

            //if (age >= 18)
            //{
            //    Console.WriteLine("You are eligible to vote.");
            //}

            //int marks = 45;

            //if (marks >= 40)
            //{
            //    Console.WriteLine("Congratulations! You passed the exam.");
            //}

            //IF–ELSE STATEMENT

            //if (condition)
            //{
            //    // true block
            //}
            //else
            //{
            //    // false block
            //}

            //int marks = 45;

            //if (marks >= 40)
            //{
            //    Console.WriteLine("You passed the exam.");
            //}
            //else
            //{
            //    Console.WriteLine("You failed the exam.");
            //}

            //bool isLoggedIn = true;

            //if (isLoggedIn)
            //{
            //    Console.WriteLine("Welcome to the dashboard.");
            //}
            //else
            //{
            //    Console.WriteLine("Please login first.");
            //}

            //ELSE IF LADDER
            //if (condition1)
            //{
            //}
            //else if (condition2)
            //{
            //}
            //else
            //{
            //}

            //int marks = 4;

            //if (marks >= 80)
            //{
            //    Console.WriteLine("Grade A");
            //}
            //else if (marks >= 60)
            //{
            //    Console.WriteLine("Grade B");
            //}
            //else if (marks >= 40)
            //{
            //    Console.WriteLine("Grade C");
            //}
            //else
            //{
            //    Console.WriteLine("Fail");
            //}

            //SWITCH STATEMENT
            //switch (expression)
            //{
            //    case value1:
            //        break;
            //    case value2:
            //        break;
            //    default:
            //        break;
            //}

            //int option = 5;

            //switch (option)
            //{
            //    case 1:
            //        Console.WriteLine("Create Account");
            //        break;

            //    case 2:
            //        Console.WriteLine("Login");
            //        break;

            //    case 3:
            //        Console.WriteLine("Exit");
            //        break;

            //    default:
            //        Console.WriteLine("Invalid option");
            //        break;
            //}

            //int day = 5;

            //switch (day)
            //{
            //    case 1:
            //        Console.WriteLine("Sunday");
            //        break;
            //    case 2:
            //        Console.WriteLine("Monday");
            //        break;
            //    case 3:
            //        Console.WriteLine("Tuesday");
            //        break;
            //    case 4:
            //        Console.WriteLine("Wednesday");
            //        break;
            //    case 5:
            //        Console.WriteLine("Thursday");
            //        break;
            //    default:
            //        Console.WriteLine("Invalid day");
            //        break;
            //}

            //BEST PRACTICES
            //✅ 1.Use if for simple conditions
            //if (isActive)
            //{
            //    // simple and clear
            //}

            //❌ 2.Avoid deep nesting
            //❌ Bad:
            //if (a > 0)
            //{
            //    if (b > 0)
            //    {
            //        if (c > 0)
            //        {
            //            Console.WriteLine("Valid");
            //        }
            //    }
            //}

            //✅ Better:
            //if (a > 0 && b > 0 && c > 0)
            //{
            //    Console.WriteLine("Valid");
            //}

            //✅ 3.Prefer switch over long else -if chains

            //✅ 4.Always handle the default case
            //default:
            //    Console.WriteLine("Unexpected input");
            //            break;

            //✅ 5.Keep conditions readable
            //❌ Bad:
            //if (x > 10 && y < 5 && z != 0 && flag == true)

            //✅ Better:
            //bool isValid = x > 10 && y < 5 && z != 0 && flag;

            //if (isValid)
            //{
            //    Console.WriteLine("Valid input");
            //}

            //Let’s summarize:
            //    * Use if → one condition
            //    * Use if-else → true vs false
            //    * Use else if → multiple ranges
            //    * Use switch → fixed values
        }
    }
}