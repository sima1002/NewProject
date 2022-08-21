using System;
using System.Collections.Generic;
using System.Text;

namespace myproject
{
    class Circle
    {
        static void main(string[] args)
        {
            int radius;
            double area; ;
            Console.WriteLine("Enter the value of radius");
            radius = int.Parse(Console.ReadLine());
            area = Math.PI * radius * radius;
            Console.WriteLine("Area of circle is:");
        }
    }
}
