
namespace Linq.SetMethods;

public class DistinctMethod
{
    public void Use_Distinct()
    {
        List<string> programmingLangs = new List<string>() { "C#", "Java", "Python", "Javascript", "Go", "C#", "Python" };

        var result = programmingLangs.Distinct();
        //.Distinct() returns distinct elements (remove repeated elements)
    }

    public void Use_Distinct_Class()
    {
        List<Product> products = Product.GetProducts();
        List<Product> products2 = new List<Product>() {
        new Product() { Id = 10, Name = "iPhone 13", CategoryId = 1, Price =15000 },
        new Product() { Id = 6, Name = "Women's Jeans", CategoryId = 3, Price = 3200},
        new Product() { Id = 12, Name = "iPhone 13", CategoryId = 1, Price =15000 },
        new Product() { Id = 11, Name = "Women's T-Shirt", CategoryId = 3, Price = 2500},
        new Product() { Id = 9, Name = "Jacket", CategoryId = 3, Price = 1000},
    };
        var result = products2.Distinct(new ProductComparer());
        //because .Distinct does not know how to distinct classes, we need to create a class of type IEqualityComparer

        foreach (var item in result)
        {
            Console.WriteLine(item.Name);
        }
    }

    
}
