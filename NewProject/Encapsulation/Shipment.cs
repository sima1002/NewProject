using System;
using System.Collections.Generic;
using System.Text;

namespace myproject.Encapsulation
{
    class Mydate
    {
        private int dd;
        private int mm;
        private int yy;

        public int Dd
        {
            get { return dd; }
            set { dd = value; }
        }
        public int Mm
        {
            get { return mm; }
            set { mm = value; }
        }
        public int Yy
        {
            get { return yy; }
            set { yy = value; }
        }
    }

    class Order
    {
        private int oid;
        private string cust_name;
        private int price;
        private string city;

        public int Oid
        {
            get { return oid; }
            set { oid = value; }

        }
        public string Cust_name
        {
            get;
            set;
        }
        public int Price
        {
            get;
            set;
        }
        public string City
        {
            get;
            set;
        }
    }
    class Shipment
    {
        private int id;
        private Order o;
        private Mydate dt;

        public int Id
        {
            get;
            set;
        }
        public Order O
        {
            get { return o; }
            set { o = value; }
        }
        public Mydate Dt
        {
            get { return dt; }
            set { dt = value; }
        }

        static void Main(string[]args)
        {
            Shipment s = new Shipment();
            s.Id = 101;
            
            s.O = new Order();
            s.O.Oid = 1;
            s.O.Cust_name = "Sweety";
            s.O.Price = 1000;
            s.O.City = "Pune";

            s.Dt = new Mydate();
            s.Dt.Dd = 5;
            s.Dt.Mm = 6;
            s.Dt.Yy = 2022;

            Console.WriteLine(s.Id + " " + s.O.Oid + " " + s.O.Cust_name + " " + s.O.Price + " " + s.O.City + " " + s.Dt.Dd + "/" + s.Dt.Mm + "/" + s.Dt.Yy);
        }

    }
}
