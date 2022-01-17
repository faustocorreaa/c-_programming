using System;

namespace IntroToMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 5;
            int[] array = { 1, 2, 3 };
            string str = "hello";

            Console.WriteLine("Before Changing: ");
            Console.WriteLine($"i={i}");
            Console.WriteLine("array[0] = " + array[0]);
            Console.WriteLine("str = "+str);

            ChangeValues(ref i, array, str);

            Console.WriteLine("\n\nAfter Changing: ");
            Console.WriteLine($"i={i}");
            Console.WriteLine("array[0] = " + array[0]);
            Console.WriteLine("str = " + str);

            int x = 20, y = 40;
            int sum, mul;
            Calculate(x, y, out sum, out mul);
            Console.WriteLine($"Sum={sum}, Mul={mul}");

            int[] a = { 5, 43, 6, 8, 7, 5, 3, 2 };
            PrintArray(a);
            PrintArray(6, 4, 2, 3, 65, 76, 8, 87, 6, 4, 43, 3, 3, 4, 5, 6);

            PersonInfo("John", 32);
            PersonInfo("John");
            PersonInfo(age: 32, name: "Jhon");

        }

        static void PrintArray(params int[] array)
        {
            Console.WriteLine($"\n\nNumber of Items: {array.Length}");

            foreach (int i in array)
                Console.Write($"{i} ");
            Console.WriteLine();
        }

        static void PersonInfo(string name, int age = 21)
        {
            Console.WriteLine($"Name: {name}, Age: {age}");
        }

        static void Calculate(int a, int b, out int sum, out int mul)
        {
            sum = a + b;
            mul = a * b;
        }

        static void ChangeValues(ref int n, int[] arr, string s)
        {
            n = 100;
            arr[0] = 100;
            s = "bye";
        }
    }
}
