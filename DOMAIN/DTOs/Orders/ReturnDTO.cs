
namespace Domain.DTOs.Orders;

public class ReturnDTO
{

    public int ID { get; set; }

    public int Amount { get; set; }

    public string? Reason { get; set; }

    public string? Condition { get; set; } // None, Returning, Returned

    public static ReturnDTO Create(int id, int amount, string reason, string condition, PurchaseDTO purchaseDTO)
    {
        ReturnDTO returndto = new ReturnDTO()
        {
            ID = id,
            Amount = amount,
            Reason = reason,
            Condition = condition,
            PurchaseDTO = purchaseDTO
        };

        return returndto;
    }

    public PurchaseDTO? PurchaseDTO { get; set; }

}