using Microsoft.EntityFrameworkCore;

namespace Homeworks;

public class ShopDbContext : DbContext
{
    public DbSet<Customer> Customers { get; set; }
    public DbSet<Employee> Employees { get; set; }
    public DbSet<Product> Products { get; set; }
    public DbSet<Order> Orders { get; set; }

    protected override void OnConfiguring (DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Data Source = (LocalDb)\\MSSQLLocalDB; Database = Shop");
    }
}
