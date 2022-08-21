using System;
using System.Collections.Generic;
using System.Text;

namespace myproject.ArraryDemo
{
    class AlternateElement
    {
        static void Main(string[] args)
        {
            int[] a = { 4, 5, 6, 2, 8 };


            for (int i = 0; i < a.Length; i++)
            {
               
                    Console.WriteLine(" " + a[i]);
                
            }
            for(int i=0;i<a.Length;i+=2)
            {
                Console.WriteLine(" " + a[i]);
            }
        }
    }
}
