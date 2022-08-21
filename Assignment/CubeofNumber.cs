using System;
using System.Collections.Generic;
using System.Text;

namespace myproject.Assignment
{
    class CubeofNumber
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Number:");
            int num = Convert.ToInt32(Console.ReadLine());
            double Sqr = Math.Pow(num, 3);
            Console.WriteLine("Cube of {0} is : {1}", num, Sqr);
            Console.ReadLine();
        }
    }
}
