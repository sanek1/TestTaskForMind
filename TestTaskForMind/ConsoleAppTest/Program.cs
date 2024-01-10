using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using LibraryCalculations;


namespace ConsoleAppTest
{
    public class Program
    {
        static void Main(string[] args)
        {
            
            var listShapes = new List<Shape>();
            listShapes.Add(ShapeFactory.CreateShape(5,5));
            listShapes.Add(ShapeFactory.CreateShape(3));
            listShapes.Add(ShapeFactory.CreateShape(4, 5));
            listShapes.Add(ShapeFactory.CreateShape(4, 4, 4));
            listShapes.Add(ShapeFactory.CreateShape(4, 5, 4));
            listShapes.Add(ShapeFactory.CreateShape(2 / 3));
            listShapes.Add(ShapeFactory.CreateShape(4, 5, 4));


            foreach (Shape s in listShapes)
            {

                if (!Validation.Check(s))
                {
                    Console.WriteLine("Error validation");
                    break;
                }
                Console.WriteLine(s.GetArea());
                Console.WriteLine();
            }

            
        }
    }

}
