using System;
using System.Collections.Generic;
using System.Text;

namespace myproject.Encapsulation
{
    class Student
    {
        private int id;
        private string name;
        private double percentage;
        
        public int Id
        {
            get;
            set;
        }
        public string Name
        {
            get;
            set;

        }
        public double Percentage
        {
            get;
            set;
        }
      

    }
    class StudInfo
    {
        static void Main(string[] args)
        {
            Student s = new Student();
            s.Id = 101;
            s.Name = "Ojasvi";
            s.Percentage = 89.67;
            Console.WriteLine(s.Id + " " + s.Name + " " + s.Percentage);

            bool isplaced = true;
            if(isplaced)
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }
        }
    }
}
