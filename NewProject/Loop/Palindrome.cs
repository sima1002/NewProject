using System;
using System.Collections.Generic;
using System.Text;

namespace myproject.Loop
{
    class Palindrome
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number:");
            int num = int.Parse(Console.ReadLine());
            int revers = 0, n;
            n = num;
            while (n > 0)
            {
                int r = n % 10;
                revers = revers * 10 + r;
                n = n / 10;
            }
            Console.WriteLine("Revers is:" + revers);
            if (num == revers)
            {
                Console.WriteLine("Number is palindrome:");
            }
            else
            {
                Console.WriteLine("Number is not palindrome:");

            }
        }
    }
}
