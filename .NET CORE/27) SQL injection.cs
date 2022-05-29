using System;
using System.IO;
using Microsoft.Data.SqlClient;

namespace hello_world
{
    class Program
    {
        static void Main(string[] args)
        {
            //sql injection.  
            string connString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=first;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            SqlConnection con = new SqlConnection(connString);
            con.Open();

            string un,psd;
            Console.Write("Enter username: ");
            un = Console.ReadLine();
            Console.Write("Enter password: ");
            psd = Console.ReadLine();
            
            string querry = "Select * from Users where username = @U and password = @P";
            //Console.WriteLine(querry);
            SqlParameter p1 =new SqlParameter("U",un);
            SqlParameter p2 =new SqlParameter("P",psd);
            SqlCommand cmd = new SqlCommand(querry,con);
            cmd.Parameter.Add(p1);
            cmd.Parameter.Add(p2);
            SqlDataReader dr = cmd.ExecuteReader();
            if(dr.HasRows)
            {
                Console.WriteLine("Data fetched.");
            }
            else
            {
                Console.WriteLine("Data not fetched.");
            }
            while(dr.Read())
            {
                Console.WriteLine($"id: {dr[0]}, Name: {dr[1]}, Password: {dr.GetValue(2)}");
            }
            con.Close();
        }
    }
}


/*
using System;
using System.IO;
using Microsoft.Data.SqlClient;


namespace practice
{
   class Program
    {
        static void Main(string[] args)
        {
            string connstr = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=first;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            SqlConnection conn = new SqlConnection(connstr);
            conn.Open();

            string un = "hassan raza";
            SqlParameter p1 = new SqlParameter("N", un);
            string rn = "bitf19a001";
            SqlParameter p2 = new SqlParameter("R", rn);
            string query = "Select * from Student where sname = @N or rollno= @R;";
            
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.Add(p1);
            cmd.Parameters.Add(p2);
            
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
}*/
