
using System.ComponentModel.DataAnnotations;

namespace DOMAIN.Entities.Customers;

public class Phone
{
    [Key]
    public int ID { get; set; }

    [Required]
    [StringLength(12)]
    public string? Number { get; set; }

    public static Phone Create(int id, string number, int customerid)
    {
        Phone phone = new Phone()
        {
            ID = id,
            Number = number,
            CustomerID = customerid
        };

        return phone;
    }

    public int CustomerID { get; set; }
    public Customer? Customer { get; set; }

}
