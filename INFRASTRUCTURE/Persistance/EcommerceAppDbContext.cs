
using Microsoft.EntityFrameworkCore;
using Domain.Entities.Adminstrators;
using Domain.Entities.Comments;
using Domain.Entities.Customers;
using Domain.Entities.Items;
using Domain.Entities.Orders;
using System.Reflection.Emit;
using System.Reflection.Metadata;

namespace Infrastructure.Persistance;

public class EcommerceAppDbContext : DbContext
{

	public EcommerceAppDbContext(DbContextOptions<EcommerceAppDbContext> options)
		: base(options)
	{

	}

    protected override void OnModelCreating(ModelBuilder builder)
    {

        builder.Entity<Chat>()
        .HasOne(e => e.Customer)
        .WithMany(e => e.Chats)
        .OnDelete(DeleteBehavior.NoAction);

        builder.Entity<Chat>()
        .HasOne(e => e.Administrator)
        .WithMany(e => e.Chats)
        .OnDelete(DeleteBehavior.NoAction);

    }

	public DbSet<Administrator>? Administrators { get; set; }

    public DbSet<Chat>? Chats { get; set; }

    public DbSet<Comment>? Comments { get; set; }

    public DbSet<Customer>? Customers { get; set; }

    public DbSet<Address>? Addresses { get; set; }

    public DbSet<Avatar>? Avatars { get; set; }

    public DbSet<CreditCard>? CreditCards { get; set; }

    public DbSet<Phone>? Phones { get; set; }

    public DbSet<Brand>? Brands { get; set; }

    public DbSet<Category>? Categories { get; set; }

    public DbSet<ClotheSize>? ClotheSizes { get; set; }

    public DbSet<Color>? Colors { get; set; }

    public DbSet<Image>? Images { get; set; }

    public DbSet<Item>? Items { get; set; }

    public DbSet<Subitem>? Subitems { get; set; }

    public DbSet<TechCapacity>? TechCapacities { get; set; }

    public DbSet<TechSize>? TechSizes { get; set; }

    public DbSet<Order>? Orders { get; set; }

    public DbSet<OrderCreditCard>? OrderCreditCards { get; set; }

    public DbSet<Purchase>? Purchases { get; set; }

    public DbSet<Return>? Returns { get; set; }

    public DbSet<ShipmentMethod>? ShipmentMethods { get; set; }

}
