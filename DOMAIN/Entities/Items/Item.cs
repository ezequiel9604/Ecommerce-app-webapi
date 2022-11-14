
using Domain.Entities.Comments;
using Domain.Helpers.Entities;
using System.ComponentModel.DataAnnotations;

namespace Domain.Entities.Items;

public class Item : IAggregateRoot
{
    [Key]
    public int ID { get; set; }

    [Required]
    [StringLength(200)]
    public string? Title { get; set; }

    [Required]
    [StringLength(int.MaxValue)]
    public string? Description { get; set; }

    public static Item Create(int id, string title, string description, int brandid, int categoryid)
    {
        Item item = new Item()
        {
            ID = id,
            Title = title,
            Description = description,
            BrandID = brandid,
            CategoryID = categoryid
        };

        return item;
    }


    public List<Image>? Images { get; set; }

    public List<Subitem>? Subitems { get; set; }

    public List<Comment>? Comments { get; set; }


    public int BrandID { get; set; }
    public Brand? Brand { get; set; }

    public int CategoryID { get; set; }
    public Category? Category { get; set; }

}