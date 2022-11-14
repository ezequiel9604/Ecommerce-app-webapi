
using System.ComponentModel.DataAnnotations;

namespace Domain.Entities.Items;

public class Brand
{

    [Key]
    public int ID { get; set; }

    [Required]
    [StringLength(20)]
    public string? Name { get; set; }

    [Required]
    [StringLength(60)]
    public string? ImagePath { get; set; }


    public static Brand Create(int id, string name, string path)
    {
        Brand brand = new Brand()
        {
            ID = id,
            Name = name,
            ImagePath = path
        };

        return brand;
    }


    public List<Item>? Items { get; set; } 
}

