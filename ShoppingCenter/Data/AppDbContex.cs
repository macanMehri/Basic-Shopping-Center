using Microsoft.EntityFrameworkCore;
using ShoppingCenter.Models;

namespace ShoppingCenter.Data
{
    public class AppDbContex:DbContext
    {
        public AppDbContex(DbContextOptions<AppDbContex> options) : base(options)
        {
        }
        
        public DbSet<Product> Products { get; set; }
    }
}
