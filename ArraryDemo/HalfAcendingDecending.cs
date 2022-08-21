using System;
using System.Collections.Generic;
using System.Text;

namespace myproject.ArraryDemo
{
    class HalfAcendingDecending
    {
        static void printOrder(int[]arr,int n)
        {
            Array.Sort(arr);
            for (int i = 0; i < n / 2; i++)
            
                Console.Write(arr[i] + " ");
            
                for(int j=n-1;j>=n/2;j--)
                
                Console.Write(arr[j] + " ");
                
                static void Main()
                {
                int[] arr = { 5, 4, 6, 2, 1, 8, 7, 9 };
                int n = arr.Length;
                printOrder(arr, n);
                    
                }

                
        }
    }
}
