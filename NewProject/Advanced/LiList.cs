using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace myproject.Advanced
{
    class LiList
    {
        static void Main(string[]args)
        {
            LinkedList<int> ll = new LinkedList<int>();
            ll.AddFirst(100);
            ll.AddFirst(200);
            ll.AddLast(300);
            ll.AddLast(400);

            LinkedListNode<int> nn = ll.Find(200);
            ll.AddBefore(nn, 1000);

            ll.AddAfter(nn, 2000);

            Console.WriteLine(ll.Count);
            Console.WriteLine(ll.Contains(34));

            LinkedListNode<int> n = ll.First;
            Console.WriteLine(n.Value);

            LinkedListNode<int> l = ll.Last;
            Console.WriteLine(l.Value);

            ll.Remove(90);

            foreach (int d in ll)
                Console.WriteLine(d);
        }
    }
}
