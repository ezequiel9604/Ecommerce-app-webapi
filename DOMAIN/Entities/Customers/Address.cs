
using System.ComponentModel.DataAnnotations;

namespace Domain.Entities.Customers;

public class Address
{

    [Key]
    public int ID { get; set; }

    [Required]
    [StringLength(60)]
    public string? Street { get; set; }

    [Required]
    [StringLength(30)]
    public string? City { get; set; }

    [Required]
    [StringLength(30)]
    public string? State { get; set; }

    [Required]
    [StringLength(10)]
    public string? Department { get; set; }

    [Required]
    [StringLength(5)]
    public string? Zipcode { get; set; }


    public static Address Create(int id, string city, string state, string department, string zipcode, int customerid)
    {
        Address address = new Address()
        {
            ID = id,
            City = city,
            State = state,
            Department = department,
            Zipcode = zipcode,
            CustomerID = customerid
        };

        return address;
    }


    public int CustomerID { get; set; }
    public Customer? Customer { get; set; }


}