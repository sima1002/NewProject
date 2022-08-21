using System;
using System.Collections.Generic;
using System.Text;

namespace myproject.Advanced
{
    class Li
    {
        static void Main(string[] args)
        {
            List<int> lst = new List<int>();
            lst.Add(100);
            lst.Add(200);
            lst.Add(300);
            lst.Add(400);
            lst.Add(500);
            lst[0] = 800;
            Console.WriteLine(lst.Count);
            Console.WriteLine(lst.Capacity);
            for (int i = 0; i < lst.Count; i++)
            {
                Console.WriteLine(lst[i]);
            }

            //lst.clear();
            Console.WriteLine(lst.Contains(90));

            List<int> lst2 = new List<int>() { 111, 112, 113 };
            lst2.AddRange(lst);

            lst2.InsertRange(1, lst);

            for (int i = 0; i < lst2.Count; i++)

                Console.WriteLine(lst2[i] + " ");
        }
    }
}
