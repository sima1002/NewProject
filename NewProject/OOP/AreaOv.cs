using System;
using System.Collections.Generic;
using System.Text;

namespace myproject.OOP
{
    class AreaOv
    {
        public void Area(double radius)
        {
            double pi = 3.14;
            double result = 3.14 * pi * pi;
            Console.WriteLine("Area of circle=" + result);
        }
        public void Area(int length,int breadth)
        {
            int result = length * breadth;
            Console.WriteLine("Area of Rectangle=" + result);

        }
        public void Area(double baseof,double height)
        {
            double result = (baseof * height) / 2;
            Console.WriteLine("Area of Triangle=" + result);
            
        }
        public void Area(int side)
        {
            int result = side * side;
            Console.WriteLine("Area of Square=" + result);
        }
        static void Main(string[] args)
        {
            AreaOv a = new AreaOv();
            a.Area(9.5);
            a.Area(10, 20);
            a.Area(2.5, 2.0);
            a.Area(15); 

        }
    }
}
