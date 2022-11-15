
using System.ComponentModel.DataAnnotations;

namespace Domain.Entities.Orders;

public class ShipmentMethod
{
    [Key]
    public int ID { get; set; }

    [Required]
    public char? Status { get; set; } // [E]xpress, [N]ormal

    [Required]
    public double Price { get; set; }

    public static ShipmentMethod Create(int id, char status, double price)
    {
        ShipmentMethod returndto = new ShipmentMethod()
        {
            ID = id,
            Status = status,
            Price = price
        };

        return returndto;
    }

    public List<Order>? Orders { get; set; }

}