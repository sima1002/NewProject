using System;
using System.Collections.Generic;
using System.Text;

namespace myproject.Assignment
{
    class CentemetrtoMeterKilom
    {
        static void Main(string[] args)
        {
            float centm, meter, kilom;
            Console.WriteLine("Enter length in cm:");
            centm = float.Parse(Console.ReadLine());
            meter = centm / 100.0f;
            kilom = centm / 100000.0f;
            Console.WriteLine("Length of meter=" + meter);
            Console.WriteLine("Length in kilometer=" + kilom);
            Console.ReadLine();
        }
    }
}
