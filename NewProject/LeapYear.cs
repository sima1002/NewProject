using System;
using System.Collections.Generic;
using System.Text;

namespace myproject
{
    class LeapYear
    {
        static void Main(String[] args)
        {
            int chk_year ;
            Console.Write("check whether given year is leap or not");
            Console.Write("Input an year:");
            chk_year = Convert.ToInt32(Console.ReadLine());
            if((chk_year%400)==0)
            Console.WriteLine("{0}is leap year\n", chk_year);
            else
                Console.WriteLine("{0}is leap year\n", chk_year);
        }
    }
}
