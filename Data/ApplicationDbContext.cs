using Easyshop.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Easyshop.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {

        public DbSet<User> Users{get; set;}

        public DbSet<Store> Stores { get; set;}

        public DbSet<Product> Products { get; set;}

        public DbSet<Order> Orders { get; set;}

        public DbSet<Cart> Carts { get; set; }
        
        public DbSet<CartItem> CartItems { get; set;}

        public DbSet<OrderItem> OrderItems { get; set;}

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
    }
}