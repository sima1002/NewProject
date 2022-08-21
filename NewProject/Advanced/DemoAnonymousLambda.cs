using System;
using System.Collections.Generic;
using System.Text;

namespace myproject.Advanced
{

    public delegate void mydel1(int a, int b);
    public delegate int mydel2(int a);
    class DemoAnonymousLambda
    {
        static void Main(string []args)
        {
            //Anonymous Function

            mydel1 d = delegate (int a, int b)
            {
                  Console.WriteLine("Product:" + (a * b));

            };
            d(9, 8);

            //Lambda

            mydel1 d2 = (a, b) => Console.WriteLine("Area of Rectangle:" + (a * b));
            d2(11, 12);

            mydel2 d3 = (a) =>
            {
                  return a * a;
            
            };

            int sq = d3(6);

            mydel2 d4 = (a) => a * a;

            int sqq = d4(9);

            Console.WriteLine("Square:" + sqq);
        }

    }
}
