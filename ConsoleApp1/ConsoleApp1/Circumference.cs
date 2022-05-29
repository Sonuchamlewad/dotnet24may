using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class propertiesInClass
    {
       public propertiesInClass(double r)
        {
            _radius = r;
        }
        private double _radius;
        private const double _pi = 3.14;
        public double radius
        {
            get
            {
                return _radius;
            }
        }
        public void printcircumference()
        {
            Console.WriteLine(2 * _pi * radius);
        }
    }
    class Circumference
    {
        public static void Main()
        {
            propertiesInClass p = new propertiesInClass(2.5);
            Console.WriteLine("radius is " + p.radius);
            p.printcircumference();
        }
    }
}
