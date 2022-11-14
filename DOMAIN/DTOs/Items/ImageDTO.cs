
namespace Domain.DTOs.Items;

public class ImageDTO
{
    public int ID { get; set; }

    public string? Path { get; set; }

    public string? Type { get; set; }

    public static ImageDTO Create(int id, string path, string type, ItemDTO itemDTO)
    {
        ImageDTO imgdto = new ImageDTO()
        {
            ID = id,
            Path = path,
            Type = type,
            ItemDTO = itemDTO
        };

        return imgdto;
    }


    public ItemDTO? ItemDTO { get; set; }

}