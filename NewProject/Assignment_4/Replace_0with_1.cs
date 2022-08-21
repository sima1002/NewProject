using System;
using System.Collections.Generic;
using System.Text;

namespace myproject.Assignment_4
{
    class Replace_0with_1
    {
        static void Main(string[]args)
        {
            int[] array = new int[] { 26, 0, 67, 45, 0, 78, 54, 34, 10, 0, 34 };
            int[] result = a(array);

        }
        static int[]a(int[]array)
        {
            int newArrayIndex = 0;
            int[] newArray = new int[array.Length];
            foreach(var element in array)
            {
                if (element == 0)
                    continue;
                newArray[newArrayIndex] = element;
                newArrayIndex++;
            }
            for (int i = newArrayIndex; i < array.Length; i++)
                newArray[i] = 0;
            return newArray;
        }
    }
}
