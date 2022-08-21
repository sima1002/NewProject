using System;
using System.Collections.Generic;
using System.Text;

namespace myproject.Advanced
{
    class Empp : IComparable<Empp>
    {
        int eno;
        string name;
        string deptname;

        public Empp(int eno, string name, string deptname)
        {
            this.eno = eno;
            this.name = name;
            this.deptname = deptname;
        }

        public int CompareTo(Empp other)
        {
            return this.name.CompareTo(other.name);
        }
        public override string ToString()
        {

            return "Eno=" + eno + "Name=" + name + "Departmentname=" + deptname;
        }
        

    }

}
