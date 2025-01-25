using System.Reflection.Metadata.Ecma335;

namespace Linq;

public class Category
{
    public int Id { get; set; }
    public string Title { get; set; }
    public List<Product> Products { get; set; } = new List<Product>();

    public static List<Category> GetCategories()
    {
        return new List<Category>(){
           new Category() { Id = 1, Title = "Mobile" },
           new Category() { Id = 2, Title = "Laptop" },
           new Category() { Id = 3, Title = "Clothes" },
        };
    }

    public static List<Category> GetCategoryWithProducts()
    {
        return new List<Category>()
        {
           new Category() { Id = 1, Title = "Mobile" ,Products = new()
           {
                new Product() { Id = 1, Name = "iPhone 14", CategoryId = 1 },
                new Product() { Id = 4, Name = "Samsung Galaxy S22", CategoryId = 1 },
                new Product() { Id = 7, Name = "Google Pixel 6", CategoryId = 1 },
           } },
           new Category() { Id = 2, Title = "Laptop" ,Products = new()
           {
                new Product() { Id = 2, Name = "MacBook Pro", CategoryId = 2 },
                new Product() { Id = 5, Name = "Dell XPS 13", CategoryId = 2 },
                new Product() { Id = 8, Name = "HP Spectre x360", CategoryId = 2 },
           }},
           new Category() { Id = 3, Title = "Clothes" ,Products = new()
           {
                new Product() { Id = 3, Name = "Men's T-Shirt", CategoryId = 3 },
                new Product() { Id = 6, Name = "Women's Jeans", CategoryId = 3 },
                new Product() { Id = 9, Name = "Jacket", CategoryId = 3 },
           }},
        };
    }
}
