using System;
using System.Collections.Generic;
using System.Text;

namespace myproject.OOP
{
    class Car
    {
        int module_no;
        string name;
        string color;
        int prize;


       
           
             static void Main(string[] args)
             {

             Car c1 = new Car();
            c1.module_no = 1;
            c1.name = "Xylo";
            c1.color = "Black";
            c1.prize = 5600000;

            Car c2 = new Car();
            c2.module_no = 2;
            c2.name = "Nexon";
            c2.color = "Red";
            c2.prize = 400000;

            Console.WriteLine(c1.module_no + " " + c1.name + " " + c1.color + " " + c1.prize);
            Console.WriteLine(c2.module_no + " " + c2.name + " " + c2.color + " " + c2.prize);

        }
    }
}
