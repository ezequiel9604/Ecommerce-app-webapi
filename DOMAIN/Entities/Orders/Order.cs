
using Domain.Helpers.Entities;
using Domain.Entities.Customers;
using System.ComponentModel.DataAnnotations;

namespace Domain.Entities.Orders;

public class Order : IAggregateRoot
{

    [Key]
    public int ID { get; set; }

    [Required]
    public DateTime OrderDate { get; set; }

    [Required]
    public DateTime ArrivaledDate { get; set; }

    [Required]
    public double Total { get; set; }
    
    [Required]
    public double Descount { get; set; }

    [Required]
    public double Subtotal { get; set; }

    [Required]
    [StringLength(100)]
    public string? Note { get; set; }

    [Required]
    public char? PaymentMethod { get; set; } // [C]redit cards or [P]aypal

    [Required]
    public char? Status { get; set; } // [I]ntransit, [D]elivered, [C]anceled

    public static Order Create(int id, DateTime orderdate, DateTime arrivaldate, double total, double descount, double subtotal, 
        string note, char paymentmethod, char status, Customer customer, ShipmentMethod ship)
    {
        Order order = new Order()
        {
            ID = id,
            OrderDate = orderdate,
            ArrivaledDate = arrivaldate,
            Total = total,
            Descount = descount,
            Subtotal = subtotal,
            Note = note,
            PaymentMethod = paymentmethod,
            Status = status,
            CustomerID = customer.ID,
            Customer = customer,
            ShipmentMethodID = ship.ID,
            ShipmentMethod = ship,
        };

        return order;
    }


    public List<Purchase>? Purchases { get; set; }

    public int CustomerID { get; set; }
    public Customer? Customer { get; set; }

    public int ShipmentMethodID { get; set; }
    public ShipmentMethod? ShipmentMethod { get; set; }

    public int OrderCreditCardID { get; set; }
    public OrderCreditCard? OrderCreditCard { get; set; }

}
