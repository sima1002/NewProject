using System;
using System.Collections.Generic;
using System.Text;

namespace myproject.ArraryDemo
{
    class OddPosition
    {
        static void Main(string[]args)
        {
            Console.WriteLine("Enter length of Array:");
            int x = int.Parse(Console.ReadLine());
            int[]a= new int[x];
            Console.WriteLine("Enter Array Element:");
            for(int i=0;i<a.Length;i++)
            {
                int e = int.Parse(Console.ReadLine());
                a[i] = e;
            }
            Console.WriteLine("Array Element are:");
            foreach(int ele in a)
            {
                Console.Write(ele + " ");
            }
            Console.WriteLine();
            Console.WriteLine("OddArray Position Element Are:");
            for(int i=0;i<a.Length;i++)
            {
                if(i%2!=0)
                {
                    Console.WriteLine(a[i]);
                }
                
            }

        }
    }
}
