
namespace Domain.DTOs.Items;

public class TechCapacityDTO
{

    public int ID { get; set; }

    public string? Capacity { get; set; }

    public static TechCapacityDTO Create(int id, string capacity)
    {
        TechCapacityDTO techcapacitydto = new TechCapacityDTO()
        {
            ID = id,
            Capacity = capacity
        };

        return techcapacitydto;
    }

    public List<ItemDTO>? Items { get; set; }

}