﻿using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace myproject.Advanced
{
    class Fia
    {
        static void Main(string[]args)
        {
            StreamReader sr = null;
            try
            {
                Console.WriteLine("Enter number");
                int a = int.Parse(Console.ReadLine());
                sr = new StreamReader("D://a.txt");
                Console.WriteLine(sr.Read());
                Console.WriteLine(sr.ReadLine());
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("In finally");
                if (sr != null)
                    sr.Close();
            }
        }
    }
}
