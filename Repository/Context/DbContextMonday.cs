using Microsoft.EntityFrameworkCore;
using Monday.Models;

public class DbContextMonday : DbContext
{
    public DbContextMonday(DbContextOptions<DbContextMonday> options)
        : base(options)
    {
    }

    public DbSet<Address> Addresses { get; set; }
    public DbSet<Checkout> Checkouts { get; set; }
    public DbSet<CheckoutProduct> CheckoutsProducts { get; set; }
    public DbSet<Employee> Employees { get; set; }
    public DbSet<Job> Jobs { get; set; }
    public DbSet<PaymentMethod> PaymentMethods { get; set; }
    public DbSet<Product> Products { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // There's a chance for you to need to define some FK, PK , essas cenas de DB
        // If so, ask for help at "" INTERNET "" (if you know what I mean)

        modelBuilder.Entity<Checkout>()
        .Property(c => c.TotalPrice)
        .HasColumnType("decimal(18,2)"); // ajusta a precisão conforme necessário

        modelBuilder.Entity<Product>()
            .Property(p => p.Price)
            .HasColumnType("decimal(18,2)"); // ajusta a precisão conforme necessário

        InitialLoadData.Seed(modelBuilder);

        base.OnModelCreating(modelBuilder);
    }

}
