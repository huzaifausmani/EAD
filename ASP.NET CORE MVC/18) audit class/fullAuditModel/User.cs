using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace fullAuditModel
{
    public class User: FullAuditModel
    {
        [StringLength(50)]
        [Required]
        public string Name { get; set; }
        public int Age { get; set; }
        public string Email { get; set; }
    }
}