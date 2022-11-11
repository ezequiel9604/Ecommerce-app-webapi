using System.ComponentModel.DataAnnotations;

namespace DOMAIN.Entities.Orders;

public class ShipmentMethod
{
    [Key]
    public int ID { get; set; }

    [Required]
    [StringLength(8)]
    public string? Status { get; set; } // express, normal

    [Required]
    public double Price { get; set; }

    public List<Order>? Orders { get; set; }

}