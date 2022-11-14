
using Domain.DTOs.Customers;

namespace Domain.DTOs.Orders;

public class OrderDTO
{
    public int ID { get; set; }

    public DateTime OrderDate { get; set; }

    public DateTime ArrivaledDate { get; set; }

    public double Total { get; set; }

    public double Descount { get; set; }

    public double Subtotal { get; set; }

    public string? Note { get; set; }

    public char? PaymentMethod { get; set; } // [C]redit cards or [P]aypal

    public char? Status { get; set; } // [I]ntransit, [D]elivered, [C]anceled

    public static OrderDTO Create(int id, DateTime orderdate, DateTime arrivaldate, double total, double descount, 
        double subtotal, string note, char paymentmethod, char status, CustomerDTO customerDTO, ShipmentMethodDTO shipmentMethodDTO)
    {
        OrderDTO orderdto = new OrderDTO()
        {
            ID = id,
            OrderDate = orderdate,
            ArrivaledDate = arrivaldate,
            Total = total,
            Descount = descount,
            Subtotal = subtotal,
            Note = note,
            PaymentMethod = paymentmethod,
            Status = status,
            CustomerDTO = customerDTO,
            ShipmentMethodDTO = shipmentMethodDTO
        };

        return orderdto;
    }

    public List<PurchaseDTO>? PurchaseDTOs { get; set; }

    public CustomerDTO? CustomerDTO { get; set; }

    public ShipmentMethodDTO? ShipmentMethodDTO { get; set; }

    public OrderCreditCardDTO? OrderCreditCardDTO { get; set; }

}