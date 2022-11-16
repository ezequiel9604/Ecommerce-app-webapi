
namespace Domain.DTOs.Orders;

public class OrderCreditCardDTO
{

    public int ID { get; set; }

    public string? Number { get; set; }

    public string? Owner { get; set; }

    public string? Code { get; set; }

    public DateTime Expiry { get; set; }

    public static OrderCreditCardDTO Create(int id, string number, string owner, string code, DateTime expiry, 
        OrderDTO orderDTO)
    {
        OrderCreditCardDTO carddto = new OrderCreditCardDTO()
        {
            ID = id,
            Number = number,
            Owner = owner,
            Code = code,
            Expiry = expiry,
            OrderDTO = orderDTO
        };

        return carddto;
    }

    public OrderDTO? OrderDTO { get; set; }

}
