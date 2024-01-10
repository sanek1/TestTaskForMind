using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryCalculations
{
    public class Circle : Shape
    {
        private int radius;

        public Circle(int radius, string id)
            : base(id)
        {
            this.radius = radius;
        }

        public override double Area
        {
            get
            {
                return radius * radius * System.Math.PI;
            }
        }
    }
}
