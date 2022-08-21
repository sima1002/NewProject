using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace myproject.Advanced
{
    class DemoThread
    {
        static void m1()
        {
            for(int i=0;i<=100;i++)
            {
                Console.WriteLine(i);
                Thread.Sleep(2000);
            }
        }
        static void Main(string[]args)
        {
            Console.WriteLine("Main starts:");
            Thread t1 = new Thread(m1);
            t1.Start();
            for(int i=0;i<=100;i++)
            {
                Console.WriteLine("GM");
            }
            Console.WriteLine("Main Ends:");
        }
    }
}
