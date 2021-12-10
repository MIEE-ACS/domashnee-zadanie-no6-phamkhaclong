using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork6
{
    class Trapezoid:Figure
    {
        public int height;
        public int largebottom;
        public int smallbottom;

        public override double Area()
        {
            return (largebottom + smallbottom) * height / 2;

        }

        public override double Perimeter()
        {
            Double x = Math.Sqrt(Math.Pow((largebottom - smallbottom) / 2,2)+Math.Pow(height,2));
            return (2 * x + largebottom + smallbottom);
        }

        public override bool Equals(object obj)
        {
            if (obj==null || GetType()!=obj.GetType())
            {
                return false;
            }
            var r = (Trapezoid)obj;
            return height.Equals(r.height) && largebottom.Equals(r.largebottom) && smallbottom.Equals(r.smallbottom);
        }
    }
}
