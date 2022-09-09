using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace webapp.Models
{
    public abstract class AuditClass
	{
        public string createdBy { get; set; }
        public string updatedBy { get; set; }
        public DateTime createdDate { get; set; }
        public DateTime updatedOn { get; set; }
    }
}
