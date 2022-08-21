using System;
using System.Collections.Generic;
using System.Text;

namespace myproject.Advanced.Assignment_1
{
    class DemoQueue_14
    {
        static void Main(string[] args)
        {
            Queue<int> q = new Queue<int>();

            q.Enqueue(100);
            q.Enqueue(200);
            q.Enqueue(300);
            q.Enqueue(400);
            q.Enqueue(500);

            int remove = q.Dequeue();
            int remo = q.Dequeue();

            foreach (int d in q)
                Console.WriteLine(d);


        }
    }
}
