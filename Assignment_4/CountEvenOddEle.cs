using System;
using System.Collections.Generic;
using System.Text;

namespace myproject.Assignment_4
{
    class CountEvenOddEle
    {
        static void Main(string[]args)
        {
            int size, even, odd;
            int[] arr;
            Console.WriteLine("Enter the size of Array:");
            size = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter{0}element in array:", size);
            arr = new int[size];
            for(int i=0;i<size;i++)
            {
                Console.Write("Number({0}):", i + 1);
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            even = 0;
            odd = 0;
            for(int i=0;i<size;i++)
            {
                if(arr[i]%2==0)
                {
                    even++;
                }
                else
                {
                    odd++;
                }
            }
            Console.Write("Total Even Elements:{0}\n", even);
            Console.Write("Total Odd Elements:{0}\n", odd);
            Console.ReadLine();
        }
    }
}
