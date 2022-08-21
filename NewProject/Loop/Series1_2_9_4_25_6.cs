using System;
using System.Collections.Generic;
using System.Text;

namespace myproject.Loop
{
    class Series1_2_9_4_25_6
    {

        static void Main(string[] args)
        {
            int i = 1;
            while (i < 25)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
                else
                {
                    Console.WriteLine(i * i);

                    i++;
                }
            }
        }               
    }
}
