using System;

namespace ArraysAndCollections
{
    class Program
    {
        static void Main()
        {
            // Array of student marks (fixed size)
            //int[] marks = new int[] { 55, 78, 90, 66, 88 };
            //int[] marks = { 55, 78, 90, 66, 88 };
            //int[] marks = new int[5]; // 5 elements, default = 0
            //int[] marks = new int[5];
            //marks[0] = 55;
            //marks[1] = 78;
            //marks[2] = 90;
            //marks[3] = 66;
            //marks[4] = 88;

            //// Access using index (0-based indexing)
            //Console.WriteLine(marks[0]); // 55
            //Console.WriteLine(marks[4]); // 88

            //// Update an element (arrays allow updating by index)
            //marks[0] = 60;

            //Console.WriteLine("Updated first mark: " + marks[0]); // 60

            //One Dimensional Array example(average +max)
            //int[] marks = { 55, 78, 90, 66, 88 };

            //int sum = 0;
            //int max = marks[0];

            //// for loop gives index control
            //for (int i = 0; i < marks.Length; i++)
            //{
            //    sum += marks[i];

            //    if (marks[i] > max)
            //        max = marks[i];
            //}

            //double avg = (double)sum / marks.Length;

            //Console.WriteLine("Average: " + avg);
            //Console.WriteLine("Highest: " + max);

            //for loop vs foreach loop(which is better for arrays ?)
            //int[] marks = { 55, 78, 90 };

            //// foreach: clean read-only style
            //foreach (int m in marks)
            //{
            //    Console.WriteLine(m);
            //}

            //// for: full control with index
            //for (int i = 0; i < marks.Length; i++)
            //{
            //    Console.WriteLine($"Index {i} => {marks[i]}");
            //}

            //Array class methods & properties(real mini demo)
            //int[] numbers = { 40, 10, 30, 20 };

            //Console.WriteLine("Length: " + numbers.Length);

            //Array.Sort(numbers);   // Sort ascending
            //Console.WriteLine("Sorted: " + string.Join(", ", numbers));

            //Array.Reverse(numbers); // Reverse order
            //Console.WriteLine("Reversed: " + string.Join(", ", numbers));

            //int index = Array.IndexOf(numbers, 20);
            //Console.WriteLine("Index of 20: " + index);

            //// Resize creates a new array under the hood and copies values
            //Array.Resize(ref numbers, 6);
            //Console.WriteLine("Resized: " + string.Join(", ", numbers)); // new slots = 0

            //What is an Implicitly Typed Array in C#?
            //var a = new[] { 10, 20, 30 };   // inferred as int[]
            //var b = new[] { "a", "b" };     // inferred as string[]
            //var c = new[] { 10, 20.5 };     // inferred as double[] (common type)

            //List<int> marks = new List<int> { 55, 78, 90 };

            //marks.Add(66);       // add new mark
            //marks.Remove(78);    // remove a mark

            //Console.WriteLine("Count: " + marks.Count);
            //Console.WriteLine(string.Join(", ", marks));

            Dictionary<string, int> studentMarks = new Dictionary<string, int>();

            studentMarks["Asha"] = 90;
            studentMarks["Bikash"] = 78;

            Console.WriteLine("Asha: " + studentMarks["Asha"]);

            // Safe lookup
            if (studentMarks.TryGetValue("Nawaraj", out int mark))
                Console.WriteLine("Nawaraj: " + mark);
            else
                Console.WriteLine("Nawaraj not found");
        }
    }
}
