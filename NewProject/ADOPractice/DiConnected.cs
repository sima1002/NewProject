using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace AdoPractice
{
    class DiConnected
    {
        static SqlDataAdapter sda = null;
        public static DataSet getAllStudents()
        {
            SqlConnection con = null;

            con = DBConnect.getConnection();
            SqlDataAdapter sda = new SqlDataAdapter("select *from student", con);
             DataSet ds = new DataSet();//collection of tables
            sda.Fill(ds, "student");

            return ds;
           
         }

        static public void AddStudent()
        {
            Console.WriteLine("Enter ID,Name,Marks:");
            int id = int.Parse(Console.ReadLine());
            string nm = Console.ReadLine();
            int mks = int.Parse(Console.ReadLine());
            DataSet ds = getAllStudents();
            SqlCommandBuilder scb = new SqlCommandBuilder(sda);

            DataRow dr = ds.Tables[0].NewRow();
            dr[0] = id;
            dr[1] = nm;
            dr[2] = mks;
            ds.Tables[0].Rows.Add(dr);

            int result = sda.Update(ds);
            Console.WriteLine(result > 0 ? "Record Inserted" : "Not");
        }
        
        
        static void Main(string[] args)
        {
            /*DataSet ds = getAllStudents();

            foreach (DataRow dr in ds.Tables["student"].Rows)
            {
                Console.WriteLine(dr[0] + " " + dr[1] + " " + dr[2]);
            }*/

            AddStudent();

        }
    }
}
