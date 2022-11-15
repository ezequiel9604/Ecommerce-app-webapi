
using Domain.DTOs.Administrators;
using Domain.DTOs.Comments;
using Domain.DTOs.Orders;

namespace Domain.DTOs.Customers;

public class CustomerDTO
{

    public int ID { get; set; }

    public string? FirstName { get; set; }

    public string? LastName { get; set; }

    public string? Email { get; set; }

    public string? Password { get; set; }

    public DateOnly DateOfBirth { get; set; }

    public char? Type { get; set; } // [E]xpress or [N]ormal

    public static CustomerDTO Create(int id, string firstname, string lastname, string email,
        string password, DateOnly birth, AvatarDTO avatarDTO)
    {

        CustomerDTO customerdto = new CustomerDTO()
        {
            ID = id,
            FirstName = firstname,
            LastName = lastname,
            Email = email,
            Password = password,
            DateOfBirth = birth,
            AvatarDTO = avatarDTO
        };

        return customerdto;
    }

    public List<ChatDTO>? ChatDTOs { get; set; }

    public List<CreditCardDTO>? CreditCardDTOs { get; set; }

    public List<AddressDTO>? AddresseDTOs { get; set; }

    public List<PhoneDTO>? PhoneDTOs { get; set; }

    public List<CommentDTO>? CommentDTOs { get; set; }

    public List<OrderDTO>? OrderDTOs { get; set; }


    public AvatarDTO? AvatarDTO { get; set; }

}
