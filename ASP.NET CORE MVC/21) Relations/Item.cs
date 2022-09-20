using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;

public class Item: FullAuditModel
{
    [StringLength(50)]
    [Required]
    public string Name { get; set; }
    public int Quantity { get; set; }
    public string Description { get; set; }

    [Range(10,100)]
    public decimal? PurchasePrice { get; set; }

    public int? CategoryId { get; set; }
    public virtual Category Category { get; set; }
    public virtual List<Company> Companies { get; set; } = new List<Company>();
}