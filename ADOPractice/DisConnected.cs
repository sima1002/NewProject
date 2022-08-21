using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace AdoPractice
{
    class DisConnected
    {
        static void Main(string[] args)
        {
            SqlConnection con = null;
            
                con = DBConnect.getConnection ();
                SqlDataAdapter sda = new SqlDataAdapter("select *from student", con);
                DataSet ds = new DataSet();//collection of tables
                sda.Fill(ds,"student");

                foreach (DataRow dr in ds.Tables ["student"].Rows )
                {
                    Console.WriteLine(dr[0] + " " + dr[1] + " " + dr[2]);
                }
            
           
           
        }
    }
}
