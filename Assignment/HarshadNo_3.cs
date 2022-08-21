using System;
using System.Collections.Generic;
using System.Text;

namespace myproject.Assignment
{
    class HarshadNo_3
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the Number:");
            int i = Convert.ToInt32(Console.ReadLine());
            CheckForHarshad(i);
        }
        private static void CheckForHarshad(int i)
        {
            int copyOfInputNumber = i; int sum = 0;
            int lastDigit = 0;

            while (i != 0)
            {
                lastDigit = i % 10;
                sum = sum + lastDigit;
                i = i / 10;

            }
            if ((copyOfInputNumber%sum)==0)
            {
                Console.WriteLine(copyOfInputNumber + " is Harshad number ");
            }
            else
            {
                Console.WriteLine(copyOfInputNumber + " is not Harshad number ");
            }
        }
    }
}
