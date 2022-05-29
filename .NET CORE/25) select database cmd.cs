using System;
using System.IO;
using Microsoft.Data.SqlClient;

//---------------------------------------------------------for select--------------------------------------------------------
        // static void Main(string[] args)
        // {
        //     string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=first;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        //     SqlConnection conn = new SqlConnection(connectionString);

        //     string query = "select * from employee;";
        //     SQLCommand cmd = new SQLCommand(query,conn);
        //     conn.open();

        //     SQLDataReader dr = cmd.ExecuteReader();

        //     while(dr.Read())
        //     {
        //         Console.WriteLine(dr[0]);
        //         Console.WriteLine(dr["Country"])
        //         Console.WriteLine(dr.GetValue(3));
        //     }
        //     conn.close();
        // }


        

namespace hello_world
{
    class Program
    {
        static void Main(string[] args)
        {
            //select statement to fetch data from database.
            string connstr = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=first;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            SqlConnection conn = new SqlConnection(connstr);
            conn.Open();
            string un = "hassan raza";
            string rn = "bitf19a001";
            //string query = "Select * from Student where sname = '" + un + "' or rollno= '" + rn + "';";
            string query = $"Select * from Student where sname = '{un}' or rollno= '{rn}';";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                Console.WriteLine("Data fetched.\n\n");
            }
            else
            {
                Console.WriteLine("Data not fetched.\n\n");
            }
            Console.WriteLine("ID\t\t\tStudent Name\t\t\tRoll No.");
            while (dr.Read())
            {
                Console.WriteLine($"{dr[0]}\t\t\t{dr.GetValue(1)}\t\t\t{dr["rollno"]}");
            }
            conn.Close();
        }
    }
}