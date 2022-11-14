

namespace Domain.DTOs.Items;

public class ColorDTO
{

    public int ID { get; set; }

    public string? Name { get; set; }

    public static ColorDTO Create(int id, string name)
    {
        ColorDTO color = new ColorDTO()
        {
            ID = id,
            Name = name
        };

        return color;
    }

    public List<ItemDTO>? ItemDTOs { get; set; }

}