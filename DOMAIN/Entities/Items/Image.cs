
using System.ComponentModel.DataAnnotations;

namespace DOMAIN.Entities.Items;

public class Image
{

    [Key]
    public int ID { get; set; }

    [Required]
    [StringLength(60)]
    public string? Path { get; set; }

    [Required]
    [StringLength(4)]
    public string? Type { get; set; }

    public static Image Create(int id, string path, string type, int itemid)
    {
        Image img = new Image()
        {
            ID = id,
            Path = path,
            Type = type,
            ItemID = itemid
        };

        return img;
    }


    public int ItemID { get; set; }
    public Item? Item { get; set; }

}
