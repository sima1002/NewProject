using System;
using System.Collections.Generic;
using System.Text;

namespace myproject.Advanced
{
    class Propo
    {
        static void m1()
        {
            Console.WriteLine("M1 starts");
            Console.WriteLine("Enter number");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("M1 ends");
        }
        public static void m2()
        {
            m1();
            Console.WriteLine("in m2222");

        }
        static void Main(string[]args)
        {
            Console.WriteLine("Main starts");
            try
            {
                m2();
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.WriteLine("Main ends");
        }
    }
}
