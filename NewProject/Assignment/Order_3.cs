using System;
using System.Collections.Generic;
using System.Text;

namespace myproject.Assignment
{
    class Order_3
    {
        private int order_id;
        private string cust_name;
        private string city;
        private string isDeliverd;

        public int Order_id
        {
            get { return order_id; }
            set { order_id = value; }
        }
        public string Cust_name
        {
            get { return cust_name; }
            set { cust_name = value; }
        }
        public string City
        {
            get { return city; }
            set { city = value; }
        }
        public string IsDeliverd
        {
            get { return isDeliverd; }
            set { isDeliverd = value; }
        }
    }
        class orderInfo
        {
            static void Main(string[] args)
            {
                Order_3 o = new Order_3();
                o.Order_id = 123;
                o.Cust_name = "Ojasvi";
                o.City = "Solapur";
                o.IsDeliverd = "Yes";
            Console.WriteLine(o.Order_id + " " + o.Cust_name + " " + o.City + " " + o.IsDeliverd);
            }
        }

    
}
