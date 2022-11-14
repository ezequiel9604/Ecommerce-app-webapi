
using Domain.DTOs.Customers;

namespace Domain.DTOs.Administrators;

public class AdministratorDTO
{

    public int ID { get; set; }

    public string? FullName { get; set; }

    public string? Email { get; set; }

    public string? Password { get; set; }

    public static AdministratorDTO Create(int id, string fullname, string email, string password, AvatarDTO avatarDTO)
    {
        AdministratorDTO admindto = new AdministratorDTO()
        {
            ID = id,
            FullName = fullname,
            Email = email,
            Password = password,
            AvatarDTO = avatarDTO
        };

        return admindto;
    }


    public List<ChatDTO>? ChatDTOs { get; set; }

    public AvatarDTO? AvatarDTO { get; set; }

}
