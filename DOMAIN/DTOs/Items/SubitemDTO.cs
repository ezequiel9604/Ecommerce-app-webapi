
using Domain.DTOs.Orders;

namespace Domain.DTOs.Items;

public class SubitemDTO
{

    public int ID { get; set; }

    public double Price { get; set; }

    public double Descount { get; set; }

    public int Stock { get; set; }

    public char State { get; set; } // [N]ew, [U]sed, [R]epair


    public static SubitemDTO Create(int id, double price, double desc, int stock, char state, 
        ItemDTO itemDTO, ColorDTO colorDTO)
    {
        SubitemDTO subitemdto = new SubitemDTO()
        {
            ID = id,
            Price = price,
            Descount = desc,
            Stock = stock,
            State = state,
            ItemDTO = itemDTO,
            ColorDTO = colorDTO
        };

        return subitemdto;
    }

    public static SubitemDTO Create(int id, double price, double desc, int stock, char state, 
        ItemDTO itemDTO, ColorDTO colorDTO, ClotheSizeDTO? clothSizeDTO)
    {
        SubitemDTO subitemdto = new SubitemDTO()
        {
            ID = id,
            Price = price,
            Descount = desc,
            Stock = stock,
            State = state,
            ItemDTO = itemDTO,
            ColorDTO = colorDTO,
            ClothSizeDTO = clothSizeDTO
        };

        return subitemdto;
    }

    public static SubitemDTO Create(int id, double price, double desc, int stock, char state,
        ItemDTO itemDTO, ColorDTO colorDTO, TechSizeDTO techSizeDTO, TechCapacityDTO techCapacityDTO)
    {
        SubitemDTO subitemdto = new SubitemDTO()
        {
            ID = id,
            Price = price,
            Descount = desc,
            Stock = stock,
            State = state,
            ItemDTO = itemDTO,
            ColorDTO = colorDTO,
            TechSizeDTO = techSizeDTO,
            TechCapacityDTO = techCapacityDTO
        };

        return subitemdto;
    }


    public List<PurchaseDTO>? PurchaseDTOs { get; set; }

    public ItemDTO? ItemDTO { get; set; }

    public ColorDTO? ColorDTO { get; set; }

    public ClotheSizeDTO? ClothSizeDTO { get; set; }

    public TechSizeDTO? TechSizeDTO { get; set; }

    public TechCapacityDTO? TechCapacityDTO { get; set; }

}
