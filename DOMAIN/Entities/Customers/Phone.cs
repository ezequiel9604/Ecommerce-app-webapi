
using System.ComponentModel.DataAnnotations;

namespace Domain.Entities.Customers;

public class Phone
{
    [Key]
    public int ID { get; set; }

    [Required]
    [StringLength(12)]
    public string? Number { get; set; }

    public static Phone Create(int id, string number, 
        Customer customer)
    {
        Phone phone = new Phone()
        {
            ID = id,
            Number = number,
            CustomerID = customer.ID,
            Customer = customer
        };

        return phone;
    }

    public int CustomerID { get; set; }
    public Customer? Customer { get; set; }

}
