using System;
using System.Collections.Generic;
using System.Text;

namespace myproject.ArraryDemo
{
    class ArrayOfSum
    {
        int add;
        int[] sum(int[] a)
        {
            for(int i=0;i<a.Length;i++)
            {
                add = add + a[i];

            }
            Console.WriteLine("Sum of Element:" + add);
            return a;
        }
        static void Main(string[]args)
        {
            int[] arr = { 2, 5, 8, 6, 3 };
            ArrayOfSum s = new ArrayOfSum();
            int[] b = s.sum(arr);
        }
    }
}
