
using Domain.DTOs.Administrators;

namespace Domain.DTOs.Customers;

public class AvatarDTO
{

    public int ID { get; set; }

    public string? Path { get; set; }

    public string? Type { get; set; }


    public static AvatarDTO Create(int id, string path, string type)
    {
        AvatarDTO avatardto = new AvatarDTO()
        {
            ID = id,
            Path = path,
            Type = type
        };

        return avatardto;
    }


    public CustomerDTO? CustomerDTO { get; set; }

    public AdministratorDTO? AdministratorDTO { get; set; }

}