using System;
using System.Collections.Generic;
using System.Text;

namespace myproject.Advanced
{
    class ClassTypesDelegate
    {
        static double m1(int r,char c)
        {
            return r * 3.4;
        }
        static void m2(byte a,string e)
        {
            Console.WriteLine("in m2" + e + a);
        }
        static bool m3(long m)
        {
            return true;
        }
        static void Main(string[]args)
        {
            Func<int, Char, double> d1 = m1;
            double d =m1(4,'h');

            Action<byte, string> d2 = m2;
            d2(33, "s");

            Predicate<long> d3 = m3;
            
        }
    }
}
