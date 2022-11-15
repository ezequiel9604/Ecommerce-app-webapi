
using Domain.Entities.Orders;
using System.ComponentModel.DataAnnotations;

namespace Domain.Entities.Items;

public class Subitem
{
    [Key]
    public int ID { get; set; }

    [Required]
    public double Price { get; set; }

    [Required]
    public double Descount { get; set; }

    [Required]
    public int Stock { get; set; }

    [Required]
    public char State { get; set; } // [N]ew, [U]sed, [R]epair

    public static Subitem Create(int id, double price, double desc, int stock, char state, 
        Item item, Color color)
    {
        Subitem subitem = new Subitem()
        {
            ID = id,
            Price = price,
            Descount = desc,
            Stock = stock,
            State = state,
            Item = item,
            ItemID = item.ID,
            Color = color,
            ColorID = color.ID
        };

        return subitem;
    }

    public List<Purchase>? Purchases { get; set; }

    public int ItemID { get; set; }
    public Item? Item { get; set; }

    public int ColorID { get; set; }
    public Color? Color { get; set; }

    public int ClothSizeID { get; set; }
    public ClotheSize? ClothSize { get; set; }

    public int TechSizeID { get; set; }
    public TechSize? TechSize { get; set; }

    public int TechCapacityID { get; set; }
    public TechCapacity? TechCapacity { get; set; }
}