using System;
using System.Collections.Generic;
using System.Text;

namespace myproject.Loop
{
    class ArmstrongNumber
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Number");
            int num = int.Parse(Console.ReadLine());
            int sum = 0;
            int temp = num;
            while (num > 0)
            {
                int r = num % 10;
                sum = sum + (r*r*r);
              
                num = num / 10;
            }
            if(temp==sum)
            {
                Console.WriteLine("Armstrong number");
            }
            else
            {
                Console.WriteLine("Not Armstrong Number");
            }
        }
    }
}
