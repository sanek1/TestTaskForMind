using LibraryCalculations;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppTest
{
    public class Validation
    {
        public static bool Check<T>(T t)
        {
            switch (t)
            {
                case Square obj:
                    Console.WriteLine(obj.GetDesription());
                    Console.WriteLine($"{obj} is a Square");
                    return true;
                case Circle obj:
                    Console.WriteLine($"{obj} is a Circle");
                    return true;
                case Triangle obj:
                    Console.WriteLine($"{obj} is a Circle!");
                    Console.WriteLine($"Треугольник - {obj.ReadPositiveNumber()}");
                    return true;
                case Rectangle obj:
                    Console.WriteLine($"{obj} is a Rectangle");
                    return true;
                default:
                    Console.WriteLine("This type does not exist");
                    return false;
            }
            return false;
        }

    }
}
