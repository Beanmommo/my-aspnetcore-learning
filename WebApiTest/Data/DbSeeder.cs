using WebApiTest.Models;

namespace WebApiTest.Data
{
    public static class DbSeeder
    {
        public static void Seed(AppDbContext context)
        {
            // Only seed if the database is empty
            if (!context.Products.Any())
            {
                context.Products.AddRange(
                    new Product { Name = "Product 1", Price = 10.0m },
                    new Product { Name = "Product 2", Price = 20.0m },
                    new Product { Name = "Product 3", Price = 30.0m }
                );
                context.SaveChanges();
            }
        }
    }
}