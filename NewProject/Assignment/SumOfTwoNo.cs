using System;
using System.Collections.Generic;
using System.Text;

namespace myproject.Assignment
{
    class SumOfTwoNo
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter two integer value:");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int sum = a + b;
            Console.WriteLine("Result=" + sum);
        }
    }
}
