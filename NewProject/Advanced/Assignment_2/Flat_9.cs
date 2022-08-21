using System;
using System.Collections.Generic;
using System.Text;

namespace myproject.Advanced.Assignment_2
{
    
    class Flat_9
    {
       

        static void Main(string[]args)
        {


            List<Flat_9> flist = new List<Flat_9>();
           
            do
            {
                Console.WriteLine("Enter FlatNo and Wing:");
                int flatno = int.Parse(Console.ReadLine());
                string wing = Console.ReadLine();
                Console.WriteLine("Enter Number of Members in Your Flat:");
                int n = int.Parse(Console.ReadLine());
                List<Member> memberlist = new List<Member>();
           
                for (int i = 1; i <= n; i++)
                {
                    Console.WriteLine("Enter Member Name,Proffesion,Age:");
                    string nmn = Console.ReadLine();
                    string prof = Console.ReadLine();
                    int age = int.Parse(Console.ReadLine());
                    Member mobj = new Member(i, nmn, prof, age);
                    memberlist.Add(mobj);
                }

                flist.Add(new Flat_9(flatno, wing, memberlist));
                Console.WriteLine("Do u Want To Add One More Flat Details");
                string choice = Console.ReadLine();

                if ((choice.ToLower() == "No"))
                    break;

            } while (true);

            foreach (Flat_9 fobj in flist)
            {
                Console.WriteLine("FlatNo" + fobj.flatno);
                Console.WriteLine("Wing" + fobj.wing);
                List<Member> mlst = fobj.memberlist;
                foreach (Member mobj in mlst)
                    Console.WriteLine(mobj);
            }

        }
    }
}
