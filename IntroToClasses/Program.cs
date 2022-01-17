using System;

namespace IntroToClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Person p1 = new Person();
            Person p2 = new Person("Mark", 32);

            Console.WriteLine(p2.ToString());

            p1.Age = 25;
            Console.WriteLine($"P1 age: {p1.Age}");

            p1.Phone = 3455677;
            Console.WriteLine($"P1 Phone is: {p1.Phone}");
        }
    }
}
