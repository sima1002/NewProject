using System;
using System.Collections.Generic;
using System.Text;

namespace myproject.Loop
{
    class SumLastFirstDigit
    {
        static void Main(string[] args)
        {
            int num,sum = 0,Fdigit,Ldigit;
            Console.WriteLine("Enter Number");
            num = Convert.ToInt32(Console.ReadLine());
            Ldigit = num % 10;
            Fdigit = num;
            while(num>=10)
            {
                num = num / 10;
            }
            Fdigit = num;
            sum = Fdigit + Ldigit;
            Console.WriteLine("Sum of first and last digit:"+sum);
            Console.ReadLine();
            
        }
    }
}
