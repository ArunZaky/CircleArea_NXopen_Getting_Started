using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircleArea
{
    class Program
    {
        static void Main(string[] args)
        {
            double radius = 3.75;
            double area = CircleArea(radius);
            Console.WriteLine("Area is {0}",area);
        }
        public static double CircleArea(double r)
        {
            double pi = System.Math.PI;
            double area = pi * r * r;
            return area;
        }
    }
}
