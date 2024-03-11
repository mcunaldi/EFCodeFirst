using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFCodeFirst.Entities.Models;
public sealed class Product
{
    [Key]
    public int ProductID { get; set; }

    [Required]
    [MaxLength(40)]
    public string ProductName { get; set; } = string.Empty;

    public int? SupplierID { get; set; }

    public Supplier? Supplier { get; set; }

    public int? CategoryID { get; set; }
    public Category? Category { get; set; }

    [MaxLength(20)]
    public string? QuantityPerUnit { get; set; }

    [Column(TypeName = "money")]
    [DefaultValue(0)]
    public decimal? UnitPrice { get; set; }

    [DefaultValue((short)0)]
    public short? UnitsInStock { get; set; }

    [DefaultValue((short)0)]
    public short? UnitsOnOrder { get; set; }

    [DefaultValue((short)0)]
    public short? ReorderLevel { get; set; }

    [Required]
    [DefaultValue(false)]
    public bool Discontinued { get; set; }
}