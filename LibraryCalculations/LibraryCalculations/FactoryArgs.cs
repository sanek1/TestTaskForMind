using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryCalculations
{
    public class FactoryArgs
    {
        public string ShapeType { get; set; }
        public string ShapeColor { get; set; }
    }
    public class ShapeFactory
    {
        private string GetDataDescription() {

            return "";
        }

        public static Shape CreateShape(int a)
        {
            return new Circle(a, "Circle");
        }

        public static Shape CreateShape(int a, int b)
        {
            if (a== b)
            {
                return new Square(a, "Square");
            }
            else
            {
                return new Rectangle(a, b, "Rectangle");
            }
            
        }
        public static Shape CreateShape(int a, int b, int c)
        {
            return new Triangle(a,b, c, "Triangle");
        }
    }

}
