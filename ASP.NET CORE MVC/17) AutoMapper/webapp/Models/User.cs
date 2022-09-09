using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace webapp.Models
{
    public class User
    {
        public int ID { get; set; }
        
        public string Name { get; set; }
        
        public int Age { get; set; }

        public double Height { get; set; }
        
        public string Gender { get; set; }
        
        public double Weight { get; set; }
    }
}
