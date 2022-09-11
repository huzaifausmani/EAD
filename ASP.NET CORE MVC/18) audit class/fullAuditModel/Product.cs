using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace fullAuditModel
{
    public class Product: FullAuditModel
    {
        [StringLength(50)]
        [Required]
        public string ProductName { get; set; }
        public int Price { get; set; }
        public string PType { get; set; }
    }
}