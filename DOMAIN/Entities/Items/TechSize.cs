using System.ComponentModel.DataAnnotations;

namespace Domain.Entities.Items;

public class TechSize
{

    [Key]
    public int ID { get; set; }

    [Required]
    [StringLength(3)]
    public string? Size { get; set; }

    public static TechSize Create(int id, string size)
    {
        TechSize techsize = new TechSize()
        {
            ID = id,
            Size = size
        };

        return techsize;
    }

    public List<Item>? Items { get; set; }

}