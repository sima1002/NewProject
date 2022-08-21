using System;
using System.Collections.Generic;
using System.Text;

namespace myproject
{
    class EvenOddSwitch
    {
        static void Main(String[] args)
        {
            int i;
            Console.WriteLine("Enter a number");
            i = int.Parse(Console.ReadLine());
            switch(i % 2)
            {
                case 0 : Console.WriteLine("Number is even");
                        break;
                default: Console.WriteLine("Number is odd");
                    break;
            }

        }
    }
}
