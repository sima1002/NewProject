using System;
using System.Collections.Generic;
using System.Text;

namespace myproject.ArraryDemo
{
    class MaximumArray
    {
        static void Main(string[] args)
        {
            int[] arr = new int[5] { 99, 85, 93, 89, 87 };
            int i, max, min, n;
            max = arr[0];
            min = arr[0];
            n = 5;
            for(i=1; i<n;i++)
            {
                if(arr[i]>max)
                {
                    max = arr[i];
                }
                if(arr[i]<min)
                {
                    min = arr[i];
                }
            }
            Console.WriteLine("Maximum Element:" + max);
            Console.WriteLine("Maximum Element:" + min);
        }





    }
}
