
using Domain.Helpers.Entities;
using Domain.Entities.Adminstrators;
using Domain.Entities.Comments;
using Domain.Entities.Orders;
using System.ComponentModel.DataAnnotations;

namespace Domain.Entities.Customers;

public class Customer : IAggregateRoot
{
    [Key]
    public int ID { get; set; }

    [Required]
    [StringLength(30)]
    public string? FirstName { get; set; }

    [Required]
    [StringLength(30)]
    public string? LastName { get; set; }

    [Required]
    [StringLength(45)]
    public string? Email { get; set; }

    [Required]
    public byte[]? PasswordHash { get; set; }

    [Required]
    public byte[]? PasswordSalt { get; set; }

    public DateOnly DateOfBirth { get; set; }

    [Required]
    public char? Type { get; set; } // [E]xpress or [N]ormal

    public static Customer Create(int id, string firstname, string lastname, string email, char type,
        byte[] hash, byte[] salt, DateOnly birth, int avatarid)
    {

        Customer customer = new Customer()
        {
            ID = id,
            FirstName = firstname,
            LastName = lastname,
            Email = email,
            Type = type,
            PasswordHash = hash,
            PasswordSalt = salt,
            DateOfBirth = birth,
            AvatarID = avatarid
        };

        return customer;

    }

    public List<CreditCard>? CreditCards { get; set; }

    public List<Address>? Addresses { get; set; }

    public List<Phone>? Phones { get; set; }

    public List<Comment>? Comments { get; set; }

    public List<Chat>? Chats { get; set; }

    public List<Order>? Orders { get; set; }


    public int AvatarID { get; set; }
    public Avatar? Avatar { get; set; }


}