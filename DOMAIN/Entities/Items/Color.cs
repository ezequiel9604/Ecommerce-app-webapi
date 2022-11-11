
using System.ComponentModel.DataAnnotations;

namespace DOMAIN.Entities.Items;

public class Color
{

    [Key]
    public int ID { get; set; }

    [Required]
    [StringLength(15)]
    public string? Name { get; set; }

    public static Color Create(int id, string name)
    {
        Color color = new Color()
        {
            ID = id,
            Name = name
        };

        return color;
    }

    public List<Item>? Items { get; set; }

}