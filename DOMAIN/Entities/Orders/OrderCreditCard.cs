using Domain.Entities.Customers;
using System.ComponentModel.DataAnnotations;

namespace Domain.Entities.Orders;

public class OrderCreditCard
{
    [Key]
    public int ID { get; set; }

    [Required]
    [StringLength(16)]
    public string? Number { get; set; }

    [Required]
    [StringLength(40)]
    public string? Owner { get; set; }

    [Required]
    [StringLength(3)]
    public string? Code { get; set; }

    [Required]
    public DateOnly Expiry { get; set; }

    public static OrderCreditCard Create(int id, string number, string owner, string code, DateOnly expiry)
    {
        OrderCreditCard card = new OrderCreditCard()
        {
            ID = id,
            Number = number,
            Owner = owner,
            Code = code,
            Expiry = expiry
        };

        return card;
    }

    public Order? Order { get; set; }

}