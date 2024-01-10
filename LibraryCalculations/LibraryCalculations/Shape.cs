using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace LibraryCalculations
{
    public abstract class Shape
    {
        private string name;

        public Shape(string s)
        {
            Id = s;
        }

        public string Id
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        public abstract double Area
        {
            get;
        }


        public string GetArea()
        {
            return $"{Id} Area = {Area:F2}";
        }
    }
}
