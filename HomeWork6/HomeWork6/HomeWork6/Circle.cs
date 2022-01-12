using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork6
{
    class Circle:Figure
    {
        public int radius;
        public override double Area()
        {
            return Math.Pow(radius, 2) * Math.PI;
        }
        public override double Perimeter()
        {
            return 2 * radius * Math.PI;
        }
        public override bool Equals(object obj)
        {
            if (obj == null || GetType()!=obj.GetType())
            {
                return false;
            }
            var R = (Circle)obj;
            return radius.Equals(R.radius);
        }
    }
}
