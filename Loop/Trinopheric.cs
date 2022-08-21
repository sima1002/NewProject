using System;
using System.Collections.Generic;
using System.Text;

namespace myproject.Loop
{
    class Trinopheric
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter any number");
            int n = int.Parse(Console.ReadLine());
            int cube = n * n * n;
            Console.WriteLine("Cube of " + n + " is:" + cube);
            int c = cube % 10;
            if(n==c)
            {
                Console.WriteLine(n + " is Trinopheric");

            }
            else
            {
                Console.WriteLine(n + " is not Trinopheric");
            }
        }
    }
}
