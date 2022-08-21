using System;
using System.Collections.Generic;
using System.Text;

namespace myproject.ArraryDemo
{
    class ArraySortingInt
    {
        public static void Main(string[]args)
        {
           
            int[] a = new int[5];
            Console.WriteLine("Enter the Element:");

            for (int i=0;i<a.Length;i++)
            {
                a[i] =int.Parse(Console.ReadLine());
             
               
            }
                for (int j =0 ; j < a.Length; j++)
                {
                   
                    Console.WriteLine((a[j]));
                }
            
           
        }
    }
}
