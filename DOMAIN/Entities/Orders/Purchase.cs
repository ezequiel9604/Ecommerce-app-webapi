
using Domain.Entities.Customers;
using Domain.Entities.Items;
using System.ComponentModel.DataAnnotations;

namespace Domain.Entities.Orders;

public class Purchase
{

    [Key]
    public int ID { get; set; }

    [Required]
    public int Amount { get; set; }

    public static Purchase Create(int id, int amount, int subitemid, int orderid)
    {
        Purchase purchase = new Purchase()
        {
            ID = id,
            Amount = amount,
            SubitemID = subitemid,
            OrderID = orderid
        };

        return purchase;
    }

    public Return? Return { get; set; }

    public int SubitemID { get; set; }
    public Subitem? Subitem { get; set; }

    public int OrderID { get; set; }
    public Order? Order { get; set; }

}