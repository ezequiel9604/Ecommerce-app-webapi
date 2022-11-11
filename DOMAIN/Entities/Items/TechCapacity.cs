using System.ComponentModel.DataAnnotations;

namespace DOMAIN.Entities.Items;

public class TechCapacity
{

    [Key]
    public int ID { get; set; }

    [Required]
    [StringLength(6)]
    public string? Capacity { get; set; }


    public List<Item>? Items { get; set; }

}