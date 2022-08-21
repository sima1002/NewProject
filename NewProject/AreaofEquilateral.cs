using System;
using System.Collections.Generic;
using System.Text;

namespace myproject
{
    class AreaofEquilateral
    { 
        static void Main(String[]args)
        {
            Console.Write("Enter length of side");
            float side = float.Parse(Console.ReadLine());
            float root = (float)Math.Sqrt(3 / 4);
            float area = root * side * side;
            Console.WriteLine("Area of equilateralof triangle is:" + area);
         
        }

    }
}
