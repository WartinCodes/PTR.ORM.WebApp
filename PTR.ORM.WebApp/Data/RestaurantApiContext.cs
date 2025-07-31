using Microsoft.EntityFrameworkCore;
using PTR.ORM.WebApp.Entities;

namespace PTR.ORM.WebApp.Data;

public class RestaurantApiContext : DbContext
{
    public DbSet<User> Users { get; set; }
    public DbSet<Product> Products { get; set; }
    public DbSet<Category> Categories { get; set; }

    public RestaurantApiContext(DbContextOptions<RestaurantApiContext> options) : base(options)
    {

    }


}