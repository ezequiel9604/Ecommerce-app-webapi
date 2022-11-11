using System.ComponentModel.DataAnnotations;

namespace DOMAIN.Entities.Items;

public class TechSize
{

    [Key]
    public int ID { get; set; }

    [Required]
    [StringLength(3)]
    public string? Size { get; set; }


    public List<Item>? Items { get; set; }

}