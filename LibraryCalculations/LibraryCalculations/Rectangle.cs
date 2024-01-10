using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryCalculations
{
    public class Rectangle : Shape
    {
        private int width;
        private int height;

        public Rectangle(int width, int height, string id)
            : base(id)
        {
            this.width = width;
            this.height = height;
        }

        public override double Area
        {
            get
            {
                return width * height;
            }
        }
    }
}
