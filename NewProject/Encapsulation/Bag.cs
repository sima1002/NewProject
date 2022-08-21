using System;
using System.Collections.Generic;
using System.Text;

namespace myproject.Encapsulation
{

    class Nib
    {
        private string material_type;

        public string Material_type
        {
            get { return material_type; }
            set { material_type = value; }
        }
    }
    class Pen
    {
        private int length;
        private string color;
        private int price;

        public int Length
        {
            get { return length; }
            set { length = value; }

        }
        public string Color
        {
            get { return color; }
            set { color = value; }
        }
        public int Price
        {
            get { return price; }
            set { price = value; }
        }
    }
    class Bag
    {
        private string brand;
        private string color;
        Pen p;
        Nib n;

        public string Brand
        {
            get { return brand; }
            set { brand = value; }
        }
        public string Color
        {
            get { return color; }
            set { color = value; }
        }
        public Pen P
        {
            get { return p; }
            set { p = value; }
        }
        public Nib N
        {
            get { return n; }
            set { n = value; }
        }

        static void Main(string[]args)
        {
            Bag b = new Bag();
            b.Brand = "Provogue";
            b.Color = "Black";
            b.P = new Pen();
            b.P.Length=149;
            b.P.Color = "Blue";
            b.P.Price = 900;

            b.N = new Nib();
            b.N.Material_type = "Plastic";

            Console.WriteLine(b.Brand + " " + b.Color + " " + b.P.Length + " "+b.P.Color + " "+b.P.Price + " " +b.N.Material_type);


        }

    }
}
