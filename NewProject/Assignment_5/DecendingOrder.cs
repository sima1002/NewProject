using System;
using System.Collections.Generic;
using System.Text;

namespace myproject.Assignment_5
{
    class DecendingOrder
    {

        static void Main(string[] args)
        {
            char[] ch = new char[5];
            Console.WriteLine("Enter array element:");
            for (int i = 0; i < ch.Length; i++)
            {
                ch[i] = Convert.ToChar(Console.ReadLine());
            }
            Console.WriteLine("..........................");
            Console.WriteLine(string.Join(" ", ch));

            for (int i = 0; i < ch.Length; i++)
            {
                for (int j = i + 1; j < ch.Length; j++)
                {
                    if (ch[i] < ch[j])
                    {
                        char temp = ch[i];
                        ch[i] = ch[j];
                        ch[j] = temp;
                    }
                }

            }

            Console.WriteLine("..............After...........");
            Console.WriteLine(string.Join(" ", ch));
        }
    }
}
