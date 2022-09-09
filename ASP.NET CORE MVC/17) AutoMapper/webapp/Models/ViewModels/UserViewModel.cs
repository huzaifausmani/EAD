using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace webapp.Models.ViewModels
{
    public class UserViewModel
    {
        public string Name { get; set; }
        
        public int Age { get; set; }

        public double Height { get; set; }    
    }
}
