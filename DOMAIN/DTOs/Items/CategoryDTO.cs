
namespace Domain.DTOs.Items;

public class CategoryDTO
{

    public int ID { get; set; }

    public string? Name { get; set; }

    public static CategoryDTO Create(int id, string name)
    {
        CategoryDTO category = new CategoryDTO()
        {
            ID = id,
            Name = name
        };

        return category;
    }

    public List<ItemDTO>? Items { get; set; }

}
