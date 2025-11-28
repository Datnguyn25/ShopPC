using Microsoft.EntityFrameworkCore;
using ShopPC.Models;

namespace ShopPC.Repository
{
    public class SeedData
    {
        public static string on { get; private set; }

        public static void SeedingData(DataContext _context)
        {
            _context.Database.Migrate();
            if(!_context.Product.Any())
            {
                CategoryModel macbook = new CategoryModel { Name = "Macbook", Description = "Macbook is Large Brand in the wold", Slug = "macbook", Status =1 };
                CategoryModel pc = new CategoryModel { Name = "Pc", Description = "Pc is Large Brand in the wold", Slug = "pc", Status = 1 };
                BrandModel dell = new BrandModel { Name = "Dell", Description = "Dell is Large Brand in the wold", Slug = "dell", Status = 1 };
                BrandModel lenovo = new BrandModel { Name = "Lenovo", Description = "Lenovo is Large Brand in the wold", Slug = "lenovo", Status = 1 };
                BrandModel apple = new BrandModel { Name = "Apple", Description = "Apple is Large Brand in the wold", Slug = "apple", Status = 1 };

                _context.Product.AddRange(
                    new ProductModel { Name = "Macbook", Description = "Macbook is best", Slug = "Macbook", Image = "1.jpg", Category = macbook, Brand = apple, Price = 1233 },
                    new ProductModel { Name = "Pc", Description = "Pc is best", Slug = "pc", Image = "1.jpg", Category = pc, Brand = lenovo, Price = 1233 }




                );                _context.SaveChanges();
            }

        }
    }
}
