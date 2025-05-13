using Microsoft.EntityFrameworkCore;
using Monday.Models;

public static class InitialLoadData
{
    public static void Seed(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Job>().HasData(
            new Job { Id = 100, Name = "Support", Description = "Support tasks", IsActive = true }
        );

        modelBuilder.Entity<Address>().HasData(
            new Address { Id = 100, Street = "Rua Nova", StreetComplement = "Apt 1", DoorNumber = "101", PostalCode = "1000-001", City = "Lisbon", Region = "Lisboa", Locale = "PT", IsActive = true }
        );

        modelBuilder.Entity<Employee>().HasData(
            new Employee
            {
                Id = 100,
                Name = "Carlos",
                BirthDate = new DateTime(1990, 1, 1),
                Email = "carlos@example.com",
                Password = "123",
                Phone = "910000000",
                AcceptedRGDPT = true,
                NIF = "123456789",
                NIB = "PT500000000000000",
                NeedsNDA = false,
                JobId = 100,
                AddressId = 100,
                IsActive = true
            }
        );

        modelBuilder.Entity<PaymentMethod>().HasData(
            new PaymentMethod { Id = 100, Type = "Credit", IsActive = true, CardNumber = "4111111111111111", ExpirationMonth = 12, ExpirationYear = 2026, Provider = "VISA" }
        );

        modelBuilder.Entity<Product>().HasData(
            new Product { Id = 100, Name = "Basic Product", Description = "Starter pack", Price = 49.99m, IsActive = true }
        );

        modelBuilder.Entity<Checkout>().HasData(
            new Checkout
            {
                Id = 100,
                EmployeeId = 100,
                PaymentMethodId = 100,
                CheckoutDate = new DateTime(2024, 1, 1),
                IsSuccessful = true,
                IsActive = true,
                TotalPrice = 99.98m
            }
        );

        modelBuilder.Entity<CheckoutProduct>().HasData(
            new CheckoutProduct
            {
                Id = 100,
                Amount = 2,
                Price = 49.99m,
                ProductId = 100,
                CheckoutId = 100,
                IsActive = true
            }
        );
    }
}
