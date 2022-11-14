using System.ComponentModel.DataAnnotations;

namespace Domain.Entities.Items;

public class ClotheSize
{

    [Key]
    public int ID { get; set; }

    [Required]
    [StringLength(3)]
    public string? Size { get; set; }


    public List<Item>? Items { get; set; }

}