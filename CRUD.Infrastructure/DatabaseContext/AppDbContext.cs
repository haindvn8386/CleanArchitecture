using CRUD.Domain.ProductEntity;
using Microsoft.EntityFrameworkCore;

namespace CRUD.Infrastructure.DatabaseContext;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }
    public DbSet<Product> Products { get; set; }
}
