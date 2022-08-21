using System;
using System.Collections.Generic;
using System.Text;

namespace myproject.ArraryDemo
{
    class OddEvenAverage
    {
        static void Main(string[]args)
        {
            int size, oddsum = 0, evensum = 0, oddcount = 0, evencount = 0;
            Console.WriteLine("Enter the size of Array:");
            size = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[size];
            Console.WriteLine("Enter Array Value:");
            for(int i=0;i<size;i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            for(int i=0;i<size;i++)
            {
                if(arr[i]%2==0)
                {
                    evensum += arr[i];
                    evencount++;
                }
                else
                {
                    oddsum += arr[i];
                    oddcount++;
                }
                
            }

            Console.WriteLine("Even average:" + evensum / evencount + "Odd average:" + oddsum / oddcount);
        }
    }
}
