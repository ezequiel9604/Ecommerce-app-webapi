
using Domain.DTOs.Comments;

namespace Domain.DTOs.Items;

public class ItemDTO
{

    public int ID { get; set; }

    public string? Title { get; set; }

    public string? Description { get; set; }


    public static ItemDTO Create(int id, string title, string description, BrandDTO brandDTO, 
        CategoryDTO categoryDTO, List<ImageDTO> imageDTOs, List<SubitemDTO> subitemDTOs)
    {
        ItemDTO itemdto = new ItemDTO()
        {
            ID = id,
            Title = title,
            Description = description,
            BrandDTO = brandDTO,
            CategoryDTO = categoryDTO,
            ImageDTOs = imageDTOs,
            SubitemDTOs = subitemDTOs
        };

        return itemdto;
    }

    public List<ImageDTO>? ImageDTOs { get; set; }

    public List<SubitemDTO>? SubitemDTOs { get; set; }

    public List<CommentDTO>? CommentDTOs { get; set; }

    public BrandDTO? BrandDTO { get; set; }

    public CategoryDTO? CategoryDTO { get; set; }

}