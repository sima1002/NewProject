using System;
using System.Collections.Generic;
using System.Text;

namespace myproject.Loop
{
    class SumofFactors
    {
        static void Main(string[] args)
        {
            int i, f = 1, num;
            Console.Write("\n\n");
            Console.Write("Calculate factorial of given Number:\n");
            Console.Write("Enter the Number:\n");
            num = Convert.ToInt32(Console.ReadLine());
            
            for(i=1;i<=num;i++)
            {
                f = f * i;
                Console.Write("The factorial of {0} is : {1}\n",num, f);
            }
        }
    }
}
