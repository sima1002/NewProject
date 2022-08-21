using System;
using System.Collections.Generic;
using System.Text;

namespace myproject.Advanced.Assignment_1
{
    class Empp_16
    {
        int eno;
        string name;
        string deptname;

        public Empp_16(int eno,string name,string deptname)
        {
            this.eno = eno;
            this.name = name;
            this.deptname = deptname;
        }

        public override string ToString()
        {
            return "Eno:" + eno + "Name:" + name + "Deptname:" + deptname;
        }

        public int Eno { get => eno; set => eno = value; }
        public string Name { get => name; set => name = value; }
        public string Deptname { get => deptname; set => deptname = value; }
        
    }
    class Demo
    {
        static void Main(string[] args)
        {
            LinkedList<Empp_16> ll = new LinkedList<Empp_16>();
            ll.AddLast(new Empp_16(11, "Nitin", "Quality"));
            ll.AddLast(new Empp_16(10, "Nilesh", "Production"));
            ll.AddLast(new Empp_16(12, "Rehan", "Maintainance"));
            ll.AddLast(new Empp_16(13, "Sujay", "Production"));
            ll.AddLast(new Empp_16(14, "Ajay", "Maintainance"));

            foreach (Empp_16 e in ll)
            {
                Console.WriteLine(e);
            }
            string dname = "";
            Console.WriteLine("/////////////");
            foreach (Empp_16 e in ll)
            {
               if(e.Eno==10)
                {
                    dname = e.Deptname;
                    break;
                }
            }

            foreach (Empp_16 e in ll)
            {
                if(e.Deptname ==dname)
                {
                    Console.WriteLine(e);
                }
            }
        }
    }
}
