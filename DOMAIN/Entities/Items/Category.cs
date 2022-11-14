
using System.ComponentModel.DataAnnotations;

namespace Domain.Entities.Items;

public class Category
{

    [Key]
    public int ID { get; set; }

    [Required]
    [StringLength(20)]
    public string? Name { get; set; }

    public static Category Create(int id, string name)
    {
        Category category = new Category()
        {
            ID = id,
            Name = name
        };

        return category;
    }

    public List<Item>? Items { get; set; }

}
