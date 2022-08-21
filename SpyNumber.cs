using System;
using System.Collections.Generic;
using System.Text;

namespace myproject
{
    class SpyNumber
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Number");
            int num = int.Parse(Console.ReadLine());
            int sum = 0;
            int m = 1;
            while(num>0)
            {
                int r = num % 10;
                sum = sum + r;
                m = m * r;
                num = num / 10;
            }
            if(sum==m)
            {
                Console.WriteLine("Number is Spy Number");
            }
            else
            {
                Console.WriteLine("Number is not spy Number");
            }
        }
    }
}
