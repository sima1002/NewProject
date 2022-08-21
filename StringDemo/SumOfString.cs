using System;
using System.Collections.Generic;
using System.Text;

namespace myproject.StringDemo
{
    class SumOfString
    {
        static void Main(string[]args)
        {
            Console.WriteLine("Enter the string");
            string str = Console.ReadLine();
            double sum = 0;
            for(int i=0;i<str.Length;i++)
            {
                if(char.IsDigit(str[i]))
                {
                    Console.WriteLine(str[i]);
                    double x = char.GetNumericValue(str[i]);
                    sum = sum + x;
                }
            }
            Console.WriteLine("Sum=" +sum);
        }
    }
}
