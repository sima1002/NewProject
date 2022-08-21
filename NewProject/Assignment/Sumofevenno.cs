using System;
using System.Collections.Generic;
using System.Text;

namespace myproject.Assignment
{
    class Sumofevenno
    {
        static void Main(string[]args)
        {
            int i, num, sum = 0;
            Console.WriteLine("Enter Number");
            num = Convert.ToInt32(Console.ReadLine());
            for(i=1;i<=20;i++)
            {
              if(i%2==0)
                {
                    sum = sum + i;
                    Console.Write(i + " ");
                    
                }


            }
            Console.WriteLine(sum);
        }
    }
}
