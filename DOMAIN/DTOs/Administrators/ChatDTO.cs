

using Domain.DTOs.Customers;

namespace Domain.DTOs.Administrators;

public class ChatDTO
{
    public int ID { get; set; }

    public string? Text { get; set; }

    public DateTime Date { get; set; }

    public bool IsRead { get; set; }

    public char Sender { get; set; } // [C]ustomer, [A]dmin

    public static ChatDTO Create(int id, string text, DateTime date, bool isread, char sender, 
        AdministratorDTO adminDTO, CustomerDTO customerDTO)
    {
        ChatDTO chatdto = new ChatDTO()
        {
            ID = id,
            Text = text,
            Date = date,
            Sender = sender,
            IsRead = isread,
            AdministratorDTO = adminDTO,
            CustomerDTO = customerDTO
        };

        return chatdto;
    }

    public AdministratorDTO? AdministratorDTO { get; set; }

    public CustomerDTO? CustomerDTO { get; set; }

}