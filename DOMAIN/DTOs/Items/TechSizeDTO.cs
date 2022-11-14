
namespace Domain.DTOs.Items;

public class TechSizeDTO
{

    public int ID { get; set; }

    public string? Size { get; set; }

    public static TechSizeDTO Create(int id, string size)
    {
        TechSizeDTO techsizedto = new TechSizeDTO()
        {
            ID = id,
            Size = size
        };

        return techsizedto;
    }

    public List<ItemDTO>? Items { get; set; }

}