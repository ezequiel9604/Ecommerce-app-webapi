using System.ComponentModel.DataAnnotations;

namespace Domain.Entities.Items;

public class TechCapacity
{

    [Key]
    public int ID { get; set; }

    [Required]
    [StringLength(6)]
    public string? Capacity { get; set; }

    public static TechCapacity Create(int id, string capacity)
    {
        TechCapacity techcapacity = new TechCapacity()
        {
            ID = id,
            Capacity = capacity
        };

        return techcapacity;
    }

    public List<Item>? Items { get; set; }

}