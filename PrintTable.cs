using System;
using System.Collections.Generic;
using System.Text;

namespace myproject
{
    class PrintTable
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Number To Print The Table=");
            int num = int.Parse(Console.ReadLine());
            int table;
            for(int i=0;i<=10;i++)
            {
                table = num * i;
                Console.WriteLine(table);
            }
        }
    }
}
