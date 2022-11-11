
using System.ComponentModel.DataAnnotations;

namespace DOMAIN.Entities.Customers;

public class CreditCard
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


    public static CreditCard Create(int id, string number, string owner, string code, DateOnly expiry, int customerid)
    {
        CreditCard creditCard = new CreditCard()
        {
            ID = id,
            Number = number,
            Owner = owner,
            Code = code,
            Expiry = expiry,
            CustomerID = customerid
        };

        return creditCard;
    }


    public int CustomerID { get; set; }
    public Customer? Customer { get; set; }

}

