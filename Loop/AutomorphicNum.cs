using System;
using System.Collections.Generic;
using System.Text;

namespace myproject.Loop
{
    class AutomorphicNum
    {
       
        
            static void Main(string[] args)
            {
                Console.WriteLine("Enter the Number");
                int num = int.Parse(Console.ReadLine());
                int square = num * num;
                while (num > 0)
                {
                if (num%10!=square%10)
                {
                    Console.Write("Not Automorphic number");
                }
                num = num / 10;
                square = square / 10;
                }
               
                Console.WriteLine("Automorphic number");
                
                

            }
        
    }
}
