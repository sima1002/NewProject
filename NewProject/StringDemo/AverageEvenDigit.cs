using System;
using System.Collections.Generic;
using System.Text;

namespace myproject.StringDemo
{
    class AverageEvenDigit
    {
        public static void Main(string[]args)
        {
            Console.WriteLine("Enter the Number");
            int num = int.Parse(Console.ReadLine());

            int avg = 1;
            int sum = 0;
            int count = 0;
            while(num>0)
            {
                int rem = num % 10;
                count++;
                num = num / 10;
                if(rem%2==0)
                {
                    sum = sum + rem;
                  
                }
                avg = sum / count;
                Console.WriteLine("Average:" + avg);
            }
        }
    }
}
