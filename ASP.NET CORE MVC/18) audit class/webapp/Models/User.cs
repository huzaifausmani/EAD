using System.IO;
using System.Data.Common;
using System;
using System.Linq;

namespace webapp.Models
{
    public class User :AuditClass
    {
        public int ID { get; set; }         //EF will create primary key against this prop in db.
        public string Name { get; set; }
        public decimal Age { get; set; }
        public double Height { get; set; }

        public string add(User u)
        {
            UserContext db = new UserContext();

            db.Users.Add(u);
            
            db.SaveChanges();
            string str = $"User id of the user recently added: {u.ID}";
            return str;
        }
    }
}