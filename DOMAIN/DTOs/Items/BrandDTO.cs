
namespace Domain.DTOs.Items;

public class BrandDTO
{

    public int ID { get; set; }

    public string? Name { get; set; }

    public string? ImagePath { get; set; }


    public static BrandDTO Create(int id, string name, string path)
    {
        BrandDTO branddto = new BrandDTO()
        {
            ID = id,
            Name = name,
            ImagePath = path
        };

        return branddto;
    }


    public List<ItemDTO>? ItemDTOs { get; set; }

}
