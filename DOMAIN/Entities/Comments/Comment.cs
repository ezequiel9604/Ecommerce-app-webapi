
using Domain.Helpers.Entities;
using Domain.Entities.Customers;
using System.ComponentModel.DataAnnotations;
using Domain.Entities.Items;

namespace Domain.Entities.Comments;

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


    public static Comment Create(int id, string text, DateOnly date, 
        Customer customer, Item item)
    {
        Comment comment = new Comment()
        {
            ID = id,
            Text = text,
            Date = date,
            CustomerID = customer.ID,
            Customer = customer,
            ItemID = item.ID,
            Item = item
        };

        return comment;
    }


    public int CustomerID { get; set; }
    public Customer? Customer { get; set; }

    public int ItemID { get; set; }
    public Item? Item { get; set; }

}