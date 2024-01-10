using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryCalculations
{
    public class Square : Shape
    {
        private int side;

        public Square(int side, string id)
            : base(id)
        {
            this.side = side;
        }

        public string GetDesription()
        {
            return $"Side - {side}";
        }

        public override double Area
        {
            get
            {
                return side * side;
            }
        }
    }
}
