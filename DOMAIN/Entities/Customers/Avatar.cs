
using Domain.Entities.Adminstrators;
using System.ComponentModel.DataAnnotations;

namespace Domain.Entities.Customers;

public class Avatar
{
    [Key]
    public int ID { get; set; }

    [Required]
    [StringLength(60)]
    public string? Path { get; set; }

    [Required]
    [StringLength(4)]
    public string? Type { get; set; }

    public static Avatar Create(int id, string path, string type)
    {
        Avatar avatar = new Avatar()
        {
            ID = id,
            Path = path,
            Type = type
        };

        return avatar;
    }

    public Customer? Customer { get; set; }

    public Administrator? Administrator { get; set; }

}
