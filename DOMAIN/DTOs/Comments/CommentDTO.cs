
using Domain.DTOs.Customers;
using Domain.DTOs.Items;

namespace Domain.DTOs.Comments;

public class CommentDTO
{
    public int ID { get; set; }

    public string? Text { get; set; }

    public DateOnly Date { get; set; }

    public char State { get; set; } // [V]isible, [N]ovisible

    public static CommentDTO Create(int id, string text, DateOnly date, 
        CustomerDTO customerDTO, ItemDTO itemDTO)
    {
        CommentDTO commentdto = new CommentDTO()
        {
            ID = id,
            Text = text,
            Date = date,
            CustomerDTO = customerDTO,
            ItemDTO = itemDTO
        };

        return commentdto;
    }

    public CustomerDTO? CustomerDTO { get; set; }

    public ItemDTO? ItemDTO { get; set; }

}