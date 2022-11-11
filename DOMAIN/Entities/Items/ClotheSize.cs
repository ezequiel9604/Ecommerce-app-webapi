using System.ComponentModel.DataAnnotations;

namespace DOMAIN.Entities.Items;

public class ClothSize
{

    [Key]
    public int ID { get; set; }

    [Required]
    [StringLength(3)]
    public string? Size { get; set; }

    public static ClothSize Create(int id, string size)
    {
        ClothSize Clothsize = new ClothSize()
        {
            ID = id,
            Size = size
        };

        return Clothsize;
    }

    public List<Item>? Items { get; set; }

}