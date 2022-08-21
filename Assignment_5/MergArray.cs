using System;
using System.Collections.Generic;
using System.Text;

namespace myproject.Assignment_5
{
    class MergArray
    {
        public static void Main(string[] args)
        {
            int[] a = { 1, 2, 3, 4, 2 };
            int[] b = { 44, 4, 77, 3 };
            int[] c = new int[a.Length + b.Length];
            int j = 0;
            Console.WriteLine(string.Join(" ", a));
            Console.WriteLine(string.Join(" ", b));
            for (int i = 0; i < a.Length; i++)
            {
                c[j] = a[i];
                j++;
            }
            for (int i = 0; i < b.Length; i++)
            {
                bool ispresent = false;
                for (int k = j - 1; k >= 0; k--)
                {
                    if (c[k] == b[i])
                    {
                        ispresent = true;
                        break;
                    }
                }
                if (ispresent == false)
                {
                    c[j] = b[i];
                    j++;
                }
            }
            Console.WriteLine("/////////////////////////////");
            for (int i = 0; i < j; i++)
            {
                Console.Write(c[i] + " ");
            }
        }
    }
}
