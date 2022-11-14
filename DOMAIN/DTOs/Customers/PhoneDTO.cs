
namespace Domain.DTOs.Customers;

public class PhoneDTO
{

    public int ID { get; set; }

    public string? Number { get; set; }

    public static PhoneDTO Create(int id, string number, CustomerDTO customerDTO)
    {
        PhoneDTO phonedto = new PhoneDTO()
        {
            ID = id,
            Number = number,
            CustomerDTO = customerDTO
        };

        return phonedto;
    }

    public CustomerDTO? CustomerDTO { get; set; }

}