using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace webapp2.Models
{
    public class User
    {
        public int ID { get; set; }
        
        public string FirstName { get; set; }
        
        public string LastName { get; set; }

        public int Age { get; set; }
    }
}