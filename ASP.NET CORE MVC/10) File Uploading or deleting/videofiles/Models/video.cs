using System.IO;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace videofiles.Models
{
    public class video
    {
        private int vid;
        public int Vid
        {
            get { return vid; }
            set { vid = value; }
        }

        private string filename;
        public string Filename
        {
            get { return filename; }
            set { filename = value; }
        }
        
        private string filepath;
        public string Filepath
        {
            get { return filepath; }
            set { filepath = value; }
        }


        public bool insertData(video v)
        {
            string conStr = @"Server=localhost\SQLEXPRESS;Database=auxi;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False;";
            SqlConnection con = new SqlConnection(conStr);
            con.Open();

            SqlParameter p1 = new SqlParameter("N", v.Filename);
            SqlParameter p2 = new SqlParameter("P", v.Filepath);
            string query = "Insert into videos(vname,vpath) values (@N,@P)";
            SqlCommand cmd = new SqlCommand(query,con);
            cmd.Parameters.Add(p1);
            cmd.Parameters.Add(p2);

            int count = cmd.ExecuteNonQuery();

            if (count>=1)
            {
                con.Close();
                return true;
            }
            else
            {
                con.Close();
                return false;
            }
        }

        public List<video> getData()
        {
            string conStr = @"Server=localhost\SQLEXPRESS;Database=auxi;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False;";
            
            SqlConnection con = new SqlConnection(conStr);
            con.Open();

            string query = "select * from videos";
            SqlCommand cmd = new SqlCommand(query, con);

            SqlDataReader dr = cmd.ExecuteReader();

            List<video> li =new List<video>();
            if (dr.HasRows)
            {
                while(dr.Read())
                {
                    video v = new video();
                    v.Filename = dr[1].ToString();
                    v.Filepath = dr[2].ToString();
                    li.Add(v);
                }
                con.Close();
                return li;
            }
            else
            {
                con.Close();
                return li;
            }
        }

        public bool checkImage(string fileName)
        {
            
            if(fileName.Split('.')[1].ToUpper() == "JPEG" || fileName.Split('.')[1].ToUpper() =="JPG" || fileName.Split('.')[1].ToUpper() =="PNG" || fileName.Split('.')[1].ToUpper() =="JPE" || fileName.Split('.')[1].ToUpper() =="BMP" || fileName.Split('.')[1].ToUpper() =="GIF")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool deleteVideo(string fillename)
        {
            string conStr = @"Server=localhost\SQLEXPRESS;Database=auxi;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False;";
            SqlConnection con = new SqlConnection(conStr);
            con.Open();

            SqlParameter p1 = new SqlParameter("N", fillename);
            string query = "DELETE from videos where vname = @N";
            SqlCommand cmd = new SqlCommand(query,con);
            cmd.Parameters.Add(p1);

            int count = cmd.ExecuteNonQuery();

            if (count>=1)
            {
                con.Close();
                return true;
            }
            else
            {
                con.Close();
                return false;
            }   
        }
    }
}
