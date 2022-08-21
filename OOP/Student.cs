using System;
using System.Collections.Generic;
using System.Text;

namespace myproject.OOP
{
    class Student
    {
        int id;
        string name;
        int sub1,sub2,sub3,t;
       
        float percentage;

           
        public void input()
        {


            id = 101;
            name = "Ojasvi";
             sub1 = 89;
             sub2 = 98;
            sub3 = 86;
        }
        public void calculate()
        {
            t = sub1 + sub2 + sub3;
            percentage = (t / 3);
            Console.WriteLine("Percentage" + percentage);
        }

                void display()
                {
                    Console.WriteLine(id + " " + name + " " +sub1+" "+sub2+" "+sub3+" "+percentage);

                }

                static void Main(string[] args)
                {
                     Student st = new Student();
                     st.input();
                     st.calculate();
                     st.display();
                }
        
    }
}
