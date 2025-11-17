using Microsoft.EntityFrameworkCore;
using ShopPC.Models;

namespace ShopPC.Repository
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }
        public DbSet<BrandModel> Brands { get; set; }
        public DbSet<ProductModel> Product { get; set; }
        public DbSet<CategoryModel> Categories { get; set; }
    }
}

