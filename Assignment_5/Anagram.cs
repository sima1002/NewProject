using System;
using System.Collections.Generic;
using System.Text;

namespace myproject.Assignment_5
{
    class Anagram
    {
        public static void Main(string[]args)
        {
            Console.WriteLine("Enter first string:");
            string s1 = Console.ReadLine();
            Console.WriteLine("Enter Second string:");
            string s2 = Console.ReadLine();
            string st1 = s1.ToUpper();
            string st2 = s2.ToUpper();

            char[] ch1 = st1.ToCharArray();
            char[] ch2 = st2.ToCharArray();
            if(ch1.Length==ch2.Length)
            {
                Console.WriteLine(string.Join(" ", ch1));
                Console.WriteLine(string.Join(" ", ch2));
                Array.Sort(ch1);
                Array.Sort(ch2);
                bool flag = true;
                for(int i=0;i<ch1.Length;i++)
                {
                    if(ch1[i]!=ch2[i])
                    {
                        flag = false;
                        break;
                    }
                }
                if(flag==true)
                {
                    Console.WriteLine("Anagram");
                }
                else
                {
                    Console.WriteLine("Not Anagram");
                }
            }
        }
    }
}
