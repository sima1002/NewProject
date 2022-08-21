using System;
using System.Collections.Generic;
using System.Text;

namespace myproject.Assignment
{
    class AreaofTraingle
    {
        static void Main(String[] args)
        {
            float h, b,area;
            Console.WriteLine("Enter the base of traingle:");
            b = float.Parse(Console.ReadLine());

            Console.WriteLine("Enter the height of traingle:");
            h = float.Parse(Console.ReadLine());

            area = (b * h) /2;
            Console.WriteLine("Area:" + area);
        }
    }
}
