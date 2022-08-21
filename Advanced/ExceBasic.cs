using System;
using System.Collections.Generic;
using System.Text;

namespace myproject.Advanced
{
    class ExceBasic
    {
        static string nm;
        static void Main(string[]args)
        {
            Console.WriteLine("Welcome");
            Console.WriteLine("Enter Number");
            try
            {
                int a = int.Parse(Console.ReadLine());
                int b = int.Parse(Console.ReadLine());
                Console.WriteLine("Division:" + a / b);
              
                try
                {
                    Console.WriteLine("Enter Age");
                    int c = int.Parse(Console.ReadLine());
                    Console.WriteLine();
                }
                catch(NullReferenceException e)
                {
                    Console.WriteLine(e.Message);
                }
                Console.WriteLine("Try ends");
            }
            catch(DivideByZeroException e)

            {
                Console.WriteLine("1");
                Console.WriteLine(e.Message);
            }
            catch(FormatException e)
            {
                Console.WriteLine("2");
                Console.WriteLine(e.Message);
            }
            catch(SystemException e)
            {
                Console.WriteLine(e.Message);
            }
            for(int i=1;i<=10;i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
