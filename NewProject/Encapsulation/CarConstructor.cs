using System;
using System.Collections.Generic;
using System.Text;

namespace myproject.Encapsulation
{
    class CarConstructor
    {
     string type_engine;


        public CarConstructor(string type_engine)
        {
            this.type_engine = type_engine;
        }
        public void show()
        {
            Console.WriteLine(type_engine);
        }
    }
    class Car
    {
        int price;
        string color;
        string name;
        CarConstructor car1;

        public Car(int price, string color, string name, CarConstructor car1)
        {
            this.price = price;
            this.color = color;
            this.name = name;
            this.car1 = car1;
        }
        void display()
        {
            Console.WriteLine(price + " " + color + " " + name + " " );
            car1.show();
        }
        static void Main()
        {
            Car c = new Car(550000, "White", "Xylo",new CarConstructor("IC_engine"));
            c.display();

        }
    }
}
