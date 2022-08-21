using System;
using System.Collections.Generic;
using System.Text;

namespace myproject
{
    class EvenOddTurnary
    {
       static void Main(string[]args)
        {
            Console.WriteLine("Enter the number");
            int num = Convert.ToInt32(Console.ReadLine());
            string Ans = num % 2 == 0 ? "Number is Even" : "Number is Odd";
            Console.WriteLine("Ans=" + Ans);
        }
    }
}
