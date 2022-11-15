
using Domain.Entities.Customers;

namespace Domain.DTOs.Customers;

public class AddressDTO
{

    public int ID { get; set; }

    public string? Street { get; set; }

    public string? City { get; set; }

    public string? State { get; set; }

    public string? Department { get; set; }

    public string? Zipcode { get; set; }


    public static AddressDTO Create(int id, string city, string state, string department, string zipcode, 
        CustomerDTO customerDTO)
    {
        AddressDTO addressdto = new AddressDTO()
        {
            ID = id,
            City = city,
            State = state,
            Zipcode = zipcode,
            Department = department,
            CustomerDTO = customerDTO
        };

        return addressdto;
    }

    public CustomerDTO? CustomerDTO { get; set; }

}