
namespace Domain.DTOs.Orders;

public class ShipmentMethodDTO
{

    public int ID { get; set; }

    public char? Status { get; set; } // [E]xpress, [N]ormal

    public double Price { get; set; }

    public static ShipmentMethodDTO Create(int id, char status, double price)
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