
using System.ComponentModel.DataAnnotations;

namespace DOMAIN.Entities.Orders;

public class PurchaseCondition
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


    public int PurchaseID { get; set; }
    public Purchase? Purchase { get; set; }

}