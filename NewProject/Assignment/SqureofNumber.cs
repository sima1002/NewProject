using System;
using System.Collections.Generic;
using System.Text;

namespace myproject.Assignment
{
    class SqureofNumber
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Number:");
            int num = Convert.ToInt32(Console.ReadLine());
            double Sqr = Math.Pow(num, 2);
            Console.WriteLine("Squre of {0} is : {1}", num, Sqr);
            Console.ReadLine();
        }
    }
}
