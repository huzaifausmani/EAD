using System;
using System.IO;
using Microsoft.Data.SqlClient;

// ------------------------------------------------------for insert(DML)------------------------------------------------------
        // static void Main(string[] args)
        // {
        //     string connectionString = "paste connection string";
        //     SqlConnection conn = new SqlConnection(connectionString);

        //     string name= "Hassan Raza";

        //     string query = "Insert into Employee values(1,'"+name+"','Lahore','Pakistan')";
        //     SQLCommand cmd = new SQLCommand(query,conn);
        //     conn.open();

        //     int count = cmd.ExecuteNonQuery();
        //     Console.WriteLine(count);

        //     conn.close();
        // }

namespace hello_world
{
    class Program
    {
        static void Main(string[] args)
        {
            //DML (CRUD) (IUD)
            string connString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=first;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            SqlConnection con = new SqlConnection(connString);
            con.Open();

            string username,password;

            Console.Write("Enter username: ");
            username = Console.ReadLine();
            Console.Write("Enter password: ");
            password = Console.ReadLine();

            string querry = $"INSERT INTO USERS(username, password) values('{username}','{password}')";
            //string querry = $"Update users set password = '{password}' where username = '{username}'";
            //string querry = $"delete from users where username = '{username}'";
            SqlCommand cmd = new SqlCommand(querry, con);
            int count = cmd.ExecuteNonQuery();
            if (count>=1)
            {
                Console.WriteLine("Row inserted/updated/deleted.");
            }
            else
            {
                Console.WriteLine("failed");
            }
            con.Close();
        }
    }
}