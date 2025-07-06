using Microsoft.EntityFrameworkCore;
using RetailInventory.Models;
using System;
using System.Threading.Tasks;

namespace RetailInventory
{
    class Program
    {
        static async Task Main(string[] args)
        {
            await ReadData();
        }

        static async Task InsertData()
        {
            using var context = new AppDbContext();

            var electronics = new Category { Name = "Electronics" };
            var groceries = new Category { Name = "Groceries" };

            await context.Categories.AddRangeAsync(electronics, groceries);

            var product1 = new Product { Name = "Laptop", Price = 75000, Category = electronics };
            var product2 = new Product { Name = "Rice Bag", Price = 1200, Category = groceries };

            await context.Products.AddRangeAsync(product1, product2);

            await context.SaveChangesAsync();

            Console.WriteLine("Initial data inserted!");
        }

        static async Task ReadData()
        {
            using var context = new AppDbContext();

            Console.WriteLine("All Products:");
            var products = await context.Products.ToListAsync();
            foreach (var p in products)
            {
                Console.WriteLine($"{p.Name} - ₹{p.Price}");
            }

            Console.WriteLine("\nFind by ID (1):");
            var product = await context.Products.FindAsync(1);
            Console.WriteLine($"Found: {product?.Name}");

            Console.WriteLine("\nFirst Product over ₹50,000:");
            var expensive = await context.Products.FirstOrDefaultAsync(p => p.Price > 50000);
            Console.WriteLine($"Expensive: {expensive?.Name}");
        }
    }
}
