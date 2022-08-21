using System;
using System.Collections.Generic;
using System.Text;

namespace myproject.Encapsulation
{
    class CarE
    {
        private int module_no;
        private string name;
        private string color;
        private int prise;

        public int Module_no
        {
            get { return module_no; }
            set { module_no = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Color
        {
            get { return color; }
            set { color = value; }
        }
        public int Prise
        {
            get { return prise; }
            set { prise = value; }
        }

    }
    class CarInfo
    {
        static void Main(string[] args)
        {
            CarE c = new CarE();
            c.Module_no = 124;
            c.Name="Xylo";
            c.Color="Black";
            c.Prise=550000;
            Console.WriteLine(c.Module_no + " " + c.Name + " " + c.Color + " " + c.Prise);
        }
    }

}
