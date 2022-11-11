
using Domain.Helpers.Domain;
using DOMAIN.Entities.Customers;
using System.ComponentModel.DataAnnotations;

namespace DOMAIN.Entities.Comments;

public class Comment : IAggregateRoot
{
    [Key]
    public int ID { get; set; }

    [Required]
    [StringLength(int.MaxValue)]
    public string? Text { get; set; }

    [Required]
    public DateOnly Date { get; set; }

    [Required]
    public char State { get; set; } // [V]isible, [N]ovisible


    public static Comment Create(int id, string text, DateOnly date, int customerid)
    {
        Comment comment = new Comment()
        {
            ID = id,
            Text = text,
            Date = date,
            CustomerID = customerid,
        };

        return comment;
    }


    public int CustomerID { get; set; }
    public Customer? Customer { get; set; }


}