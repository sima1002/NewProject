using System;
using System.Collections.Generic;

namespace myproject
{
    class MaximumDiff
    {
        static int maxDiff(int[]arr,int arr_size)
        {
            int max_diff = arr[1] - arr[0];
            int i, j;
            for(i=0;i<arr_size;i++)
            {
                for(j=0;i<arr_size;j++)
                {
                    if (arr[j] - arr[i] > max_diff)
                        max_diff = arr[j] - arr[i];
                }
            }
            return max_diff;
        }
        public static void Main()
        {
            int[] arr = { 1, 2, 90, 10, 100 };
            Console.WriteLine("Maximum Difference is:" + maxDiff(arr, 5));
        }
    }
}
