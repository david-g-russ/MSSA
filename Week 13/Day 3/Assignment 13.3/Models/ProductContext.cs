using Microsoft.EntityFrameworkCore;

namespace Assignment_13._3.Models
{
    public class ProductContext : DbContext
    {
        public ProductContext(DbContextOptions<ProductContext> options) : base(options)
        {

        }

        public DbSet<Product> Products { get; set; }

        public DbSet<ProductType> ProductTypes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasData(
                new Product()
                {
                    Id = 101,
                    Name = "Xbox",
                    Description = "Homework delayer",
                    Price = 500.00m,
                    ImageName = "xbox.jpg",
                    ProdType = ProdType.Okay
                },
                new Product()
                {
                    Id = 102,
                    Name = "Playstation",
                    Description = "Inferior to Xbox",
                    Price = 600.00m,
                    ImageName = "ps.png",
                    ProdType = ProdType.Worst
                },
                new Product()
                {
                    Id = 103,
                    Name = "PC",
                    Description = "Master race",
                    Price = 1500.00m,
                    ImageName = "pc.jpg",
                    ProdType = ProdType.Best
                },
                new Product()
                {
                    Id = 104,
                    Name = "iPhone",
                    Description = "For casuals",
                    Price = 900.00m,
                    ImageName = "iphone.jpg",
                    ProdType = ProdType.Casual
                }
                );
            modelBuilder.Entity<ProductType>().HasData(
                new ProductType() { TypeId = 1, TypeName = "None" },
                new ProductType() { TypeId = 2, TypeName = "Best" },
                new ProductType() { TypeId = 3, TypeName = "Okay" },
                new ProductType() { TypeId = 4, TypeName = "Worst" },
                new ProductType() { TypeId = 5, TypeName = "Casual" }
                );
        }
    }
}
