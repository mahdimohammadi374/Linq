using System.Diagnostics.CodeAnalysis;

namespace Linq;

public class Product
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Price { get; set; }
    public int CategoryId { get; set; }
    public string CategoryTitle { get; set; }

    public static List<Product> GetProducts()
    {
        return new List<Product>() {
        new Product() { Id = 1, Name = "iPhone 14", CategoryId = 1, Price =10000 },
        new Product() { Id = 4, Name = "Samsung Galaxy S22", CategoryId = 1, Price =12000 },
        new Product() { Id = 7, Name = "Google Pixel 6", CategoryId = 1, Price = 11000},
        new Product() { Id = 2, Name = "MacBook Pro", CategoryId = 2, Price = 23000},
        new Product() { Id = 5, Name = "Dell XPS 13", CategoryId = 2, Price = 20000},
        new Product() { Id = 8, Name = "HP Spectre x360", CategoryId = 2, Price = 8000},
        new Product() { Id = 3, Name = "Men's T-Shirt", CategoryId = 3, Price = 2000},
        new Product() { Id = 6, Name = "Women's Jeans", CategoryId = 3, Price = 3200},
        new Product() { Id = 9, Name = "Jacket", CategoryId = 3, Price = 1000},
    };
    }
    public static Product[] GetProductsArray()
    {
        return [
        new Product() { Id = 1, Name = "iPhone 14", CategoryId = 1, Price =10000 },
        new Product() { Id = 4, Name = "Samsung Galaxy S22", CategoryId = 1, Price =12000 },
        new Product() { Id = 7, Name = "Google Pixel 6", CategoryId = 1, Price = 11000},
        new Product() { Id = 2, Name = "MacBook Pro", CategoryId = 2, Price = 23000},
        new Product() { Id = 5, Name = "Dell XPS 13", CategoryId = 2, Price = 20000},
        new Product() { Id = 8, Name = "HP Spectre x360", CategoryId = 2, Price = 8000},
        new Product() { Id = 3, Name = "Men's T-Shirt", CategoryId = 3, Price = 2000},
        new Product() { Id = 6, Name = "Women's Jeans", CategoryId = 3, Price = 3200},
        new Product() { Id = 9, Name = "Jacket", CategoryId = 3, Price = 1000},
    ];
    }
}

public class ProductComparer : IEqualityComparer<Product>
{
    public bool Equals(Product? prod1, Product? prod2)
    {
        return prod1.Name == prod2.Name;
    }

    public int GetHashCode([DisallowNull] Product obj)
    {
        return obj.Name.GetHashCode();
    }
} 
