
namespace Domain.DTOs.Items;

public class ClotheSizeDTO
{

    public int ID { get; set; }

    public string? Size { get; set; }

    public static ClotheSizeDTO Create(int id, string size)
    {
        ClotheSizeDTO clothsizedto = new ClotheSizeDTO()
        {
            ID = id,
            Size = size
        };

        return clothsizedto;
    }

    public List<ItemDTO>? Items { get; set; }

}