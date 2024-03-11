using System.ComponentModel.DataAnnotations;

namespace EFCodeFirst.Entities.Models;
public sealed class Category
{
    [Key]
    public int CategoryID { get; set; }

    [Required]
    [MaxLength(15)]
    public string CategoryName { get; set; } = string.Empty;

    public string? Description { get; set; }

    public byte[]? Picture { get; set; }
}