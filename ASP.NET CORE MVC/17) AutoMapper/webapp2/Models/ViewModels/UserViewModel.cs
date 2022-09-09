using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace webapp2.Models.ViewModels
{
    public class UserViewModel
    {
        public string FName { get; set; }
        
        public string LName { get; set; }  
    }
}