using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork6
{
    class Rectangle : Figure
    {
        public int width;
        public int length;
        public override Double Area()
        {
            return width*length;
        }
        public override double Perimeter()
        {
            return 2 * (width + length);
        }
        public override bool Equals(object obj)
        {
           if (obj==null || GetType()!=obj.GetType())
           {
               return false;
           }
           var R = (Rectangle)obj;
           return width.Equals(R.width) && length.Equals(R.length);
        }
    }
}
