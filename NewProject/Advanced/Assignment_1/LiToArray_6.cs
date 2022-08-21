using System;
using System.Collections.Generic;
using System.Text;

namespace myproject.Advanced.Assignment_1
{
    class LiToArray_6
    {
        static void Main(string[] args)
        {
            List<int> l = new List<int>() { 10, 11, 12, 13, 14, 15 };
            int[] array = l.ToArray();
            Console.WriteLine(array);
        }
    }
}
