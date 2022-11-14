
namespace Domain.DTOs.Orders;

public class ShipmentMethodDTO
{

    public int ID { get; set; }

    public string? Status { get; set; } // express, normal

    public double Price { get; set; }

    public static ShipmentMethodDTO Create(int id, string status, double price)
    {
        ShipmentMethodDTO returndto = new ShipmentMethodDTO()
        {
            ID = id,
            Status = status,
            Price = price
        };

        return returndto;
    }

    public List<OrderDTO>? OrderDTOs { get; set; }

}