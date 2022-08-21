using System;
using System.Collections.Generic;
using System.Text;

namespace myproject.Loop
{
    class MenudrivenArea
    {
        static void Main(string[] args)
        {
            int choice, r, l, w, b, h,s;
            double area = 0;
            Console.Write("\n\n");
            Console.Write("a menu driven program to calculate area:");
            Console.Write("Input 1 for area of circle\n");
            Console.Write("Input 2 for area of rectangle\n");
            Console.Write("Input 3 for area of triangle\n");
            Console.Write("Input 4 for area of square\n");
            Console.Write("Enter your choice:\n");
            choice = Convert.ToInt32(Console.ReadLine());

            switch(choice)
            {
                case 1:
                    Console.Write("Enter radius of the circle:");
                    r = Convert.ToInt32(Console.ReadLine());
                    area = 3.14 * r * r;
                    break;

                case 2:
                    Console.Write("Enter lenght of the rectangle:");
                    l = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter width of the rectangle:");
                    w = Convert.ToInt32(Console.ReadLine());
                    area = l*w;
                    break;

                case 3:
                    Console.Write("Enter base of the triangle:");
                    b = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter height of the triangle:");
                    h = Convert.ToInt32(Console.ReadLine());
                    area = .5*b*h;
                    break;

                case 4:
                    Console.Write("Enter side of the square:");
                    s = Convert.ToInt32(Console.ReadLine());
                    area = s * s;
                    break;

              
                   

            }
            Console.Write("The area is:{0}\n", area);
        }
    }
}
