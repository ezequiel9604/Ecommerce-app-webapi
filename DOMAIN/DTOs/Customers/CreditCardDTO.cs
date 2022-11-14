

namespace Domain.DTOs.Customers;

public class CreditCardDTO
{
    public int ID { get; set; }

    public string? Number { get; set; }

    public string? Owner { get; set; }

    public string? Code { get; set; }

    public DateOnly Expiry { get; set; }


    public static CreditCardDTO Create(int id, string number, string owner, string code, DateOnly expiry, 
        CustomerDTO customerDTO)
    {
        CreditCardDTO creditCarddto = new CreditCardDTO()
        {
            ID = id,
            Number = number,
            Owner = owner,
            Code = code,
            Expiry = expiry,
            CustomerDTO = customerDTO
        };

        return creditCarddto;
    }


    public CustomerDTO? CustomerDTO { get; set; }

}