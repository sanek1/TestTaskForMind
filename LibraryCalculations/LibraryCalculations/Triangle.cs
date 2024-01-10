using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace LibraryCalculations
{
    public class Triangle : Shape
    {
        private int a;
        private int b;
        private int c;

        public Triangle(int a, int b, int c, string id)
            : base(id)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        public override double Area
        {
            get
            {
                var p = (a + b + c) / 2;
                return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            }
        }

        public string ReadPositiveNumber()
        {
            if (a + b <= c || a + c <= b || b + c <= a)
                return "Не треугольник";

            if (a == b && b == c)
                return "Равносторонний";

            if (a == b || b == c || a == c)
                return "Равнобедренный";

            return "Обычный";
        }
    }
}
