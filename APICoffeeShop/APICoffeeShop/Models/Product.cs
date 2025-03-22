using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace APICoffeeShop.Models;

[Table("Products")]
public class Product
{
    [Key]
    public int ProductId { get; set; }
    [Required]
    [StringLength(80)]
    public string? Name { get; set; }
    [Required]
    [StringLength(300)]
    public string? ImageUrl { get; set; }
    [Required]
    [StringLength(400)]
    public string? Description { get; set; }
    [Required]
    [Column(TypeName ="decimal(10,2)")]
    public decimal Price { get; set; }
    public DateTime ReleaseDate { get; set; }

    public int CategoryId { get; set; }
    public Category? Category { get; set; }
}

