using System.ComponentModel.DataAnnotations;

namespace Domain.Entities.Items;

public class ClotheSize
{

    [Key]
    public int ID { get; set; }

    [Required]
    [StringLength(3)]
    public string? Size { get; set; }

    public static ClotheSize Create(int id, string size)
    {
        ClotheSize clothesize = new ClotheSize()
        {
            ID = id,
            Size = size
        };

        return clothesize;
    }

    public List<Item>? Items { get; set; }

}