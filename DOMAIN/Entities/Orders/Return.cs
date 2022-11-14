
using System.ComponentModel.DataAnnotations;

namespace Domain.Entities.Orders;

public class Return
{

    [Key]
    public int ID { get; set; }

    [Required]
    public int Amount { get; set; }

    [Required]
    [StringLength(80)]
    public string? Reason { get; set; }

    [Required]
    [StringLength(12)]
    public string? Condition { get; set; } // None, Returning, Returned


    public static Return Create(int id, int amount, string reason, string condition, Purchase purchase)
    {
        Return returndto = new Return()
        {
            ID = id,
            Amount = amount,
            Reason = reason,
            Condition = condition,
            Purchase = purchase
        };

        return returndto;
    }

    public int PurchaseID { get; set; }
    public Purchase? Purchase { get; set; }

}