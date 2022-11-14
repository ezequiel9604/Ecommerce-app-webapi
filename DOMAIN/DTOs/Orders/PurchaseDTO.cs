
using Domain.DTOs.Items;

namespace Domain.DTOs.Orders;

public class PurchaseDTO
{

    public int ID { get; set; }

    public int Amount { get; set; }

    public static PurchaseDTO Create(int id, int amount, SubitemDTO subitemDTO, OrderDTO orderDTO)
    {
        PurchaseDTO purchasedto = new PurchaseDTO()
        {
            ID = id,
            Amount = amount,
            SubitemDTO = subitemDTO,
            OrderDTO = orderDTO
        };

        return purchasedto;
    }

    public ReturnDTO? ReturnDTO { get; set; }

    public SubitemDTO? SubitemDTO { get; set; }

    public OrderDTO? OrderDTO { get; set; }


}
