using System;
using System.Collections.Generic;
using System.Text;

namespace myproject.Inheritance
{

    class Vehical
    {
        public virtual void run()
        {
            Console.WriteLine("Vehical is Running.......");
        }
    }
    class Car:Vehical
    {
        public override void run()
        {
            Console.WriteLine("car is Running.......");

        }
    }

    class Truck:Vehical
    {
        public override void run()
        {
            Console.WriteLine("Truck is Running......");
        }
    }

    class Overriding
    {
        static void Main(string[]args)
        {
            Vehical v = new Car();
            v.run();

            Vehical l = new Truck();
            l.run();
        }

    }
}
