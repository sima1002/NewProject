using System;
using System.Collections.Generic;
using System.Text;

namespace myproject.Assignment_4
{
    class FizzBuzz
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Multiples of 3,5 and 3,and 5 Both");

            for (int i = 1; i <= 50; i++)
            {
                if (i % 3 == 0)
                {
                    Console.WriteLine("Buzz", +i);
                    int count = 0;
                    count++;
                    Console.WriteLine(count);
                }
                else if(i%5==0)
                {
                    Console.WriteLine("Fizz",+i);
                    int count = 0;
                    count++;
                    Console.WriteLine(count);
                }
                else if(i%3==0&&i%5==0)
                {
                    Console.WriteLine("FizzBuzz",+i);
                    int count = 0;
                    count++;
                    Console.WriteLine(count);
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
        }
            
    }
}
