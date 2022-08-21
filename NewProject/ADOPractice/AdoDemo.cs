using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;

namespace AdoPractice
{
    static class DBConnect
    {
        public static SqlConnection getConnection()
        {
            string str = "server=DESKTOP-DGOT7OC\\SQLEXPRESS01;Database=HR;Integrated Security=true";
            SqlConnection con = null;

            try
            {
                con = new SqlConnection(str);
                con.Open();

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return con;
        }
    }
    class DemoInsert
    {
        static void Main(string[] args)
        {
            SqlConnection con = DBConnect.getConnection();
            Console.WriteLine("Enter Id,Name,Marks");
            int rollno = int.Parse(Console.ReadLine());
            string Name = Console.ReadLine();
            int Marks = int.Parse(Console.ReadLine());
            SqlCommand cmd = new SqlCommand("insert into student values(@id,@nm,@Mk)", con);
            cmd.Parameters.AddWithValue("@id", rollno);
            cmd.Parameters.AddWithValue("@nm", Name);
            cmd.Parameters.AddWithValue("@Mk", Marks);


            int i = cmd.ExecuteNonQuery();
            if (i > 0)
                Console.WriteLine("Record insrted");


        }
        static void Main1(string[] args)
        {


            SqlConnection con = DBConnect.getConnection();
            SqlCommand cmd = new SqlCommand("insert into student values(1,'Sima',89)", con);
           
            int i = cmd.ExecuteNonQuery();
            if (i > 0)
                Console.WriteLine("Record insrted");
        }
    }

    class DemoUpdate
    {
        static void Main(string[] args)
        {
            SqlConnection con = DBConnect.getConnection();
            SqlCommand cmd = new SqlCommand("update student set Name='Gayatri'where Id=1", con);

            int i = cmd.ExecuteNonQuery();
            if (i > 0)
                Console.WriteLine("Record updated");
        }
    }

    class DemoDelete
    {
        static void Main(string[] args)
        {
            SqlConnection con = DBConnect.getConnection();
            SqlCommand cmd = new SqlCommand("delete student where Id=3", con);

            int i = cmd.ExecuteNonQuery();
            if (i > 0)
                Console.WriteLine("Record deleted");
        }
    }
    class AdoDemo
    {
        static void Main(string[] args)
        {
            string str = "server=DESKTOP-DGOT7OC\\SQLEXPRESS01;Database=HR;Integrated Security=true";
            SqlConnection con = null;

            try
            {
                con = new SqlConnection(str);
                con.Open();
                SqlCommand sqlCommand = new SqlCommand("select first_name,salary from employees", con);

                SqlDataReader dr=sqlCommand.ExecuteReader();

                while (dr.Read ())
                {
                    Console.WriteLine("Name=" + dr["first_name"]  + " Salary=" + dr[1]);
                }
            }

            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }

            finally
            {
                if (con != null)
                    con.Close();
            }
        }
    }
}
