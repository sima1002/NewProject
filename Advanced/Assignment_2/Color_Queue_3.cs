using System;
using System.Collections.Generic;
using System.Text;

namespace myproject.Advanced.Assignment_2
{
    class Color_Queue_3
    {
        
        
            static void Main(string[] args)
            {
                Queue<string> ll = new Queue<string>();
                ll.Enqueue("Red");
                ll.Enqueue("Pink");
                ll.Enqueue("White");
                ll.Enqueue("Black");

                foreach (string color in ll)
                {
                    Console.WriteLine(ll);
                }
            }
        
    }
}
