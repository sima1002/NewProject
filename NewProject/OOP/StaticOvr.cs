using System;
using System.Collections.Generic;
using System.Text;

namespace myproject.OOP
{
    class StaticOvr
    {
         static void Addition(int a,int b)
         {
            Console.WriteLine("Addition:" + (a + b));
         }
         static void Addition(int x,int y,int z)
         {
            Console.WriteLine("Addition:" + (x + y + z));
         }
        static void Main(string[] args)
        {
            StaticOvr.Addition(5, 9);
            StaticOvr.Addition(3, 5, 6);
        }
    }
}
