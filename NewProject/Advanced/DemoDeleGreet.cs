using System;
using System.Collections.Generic;
using System.Text;

namespace myproject.Advanced
{
    class DemoDeleGreet
    {
        static void greet()
        {
            Console.WriteLine("Happy Morning");
        }
        static void m2(int a, int b, Action d1)
        {
            Console.WriteLine("Addition" + (a + b));
            d1();
        }
        static void isEven(int n)
        {
            Console.WriteLine("In even" + n);
           // return n % 2 == 0;
        }
        static void print(int a)
        {
            Console.WriteLine("**" + a);
        }

        static void Main(string []args)
        {
            m2(10, 20, () => Console.WriteLine("Happy Morn"));

            List<int> lst = new List<int>() { 11, 45, 34, 66, 79, 99, 13, 14 };

            List<int> l = lst.FindAll(a => a % 2 == 0);

            //print all
            //lst.ForEach(print);

            lst.ForEach(d => Console.WriteLine(d));

            foreach (int d in l)
                Console.WriteLine(d);


            List<int> l2 = new List<int>();

            foreach (int d in lst)
            {
                if(d%2==0)
                {
                    l2.Add(d);
                }
            }
        }
    }
}
