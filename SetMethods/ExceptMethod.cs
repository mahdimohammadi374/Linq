﻿namespace Linq.SetMethods;

public class ExceptMethod
{
    public void Use_Except()
    {
        List<string> programmingLangs = new List<string>() { "C#", "Java", "Python", "Javascript", "Go", "C#", "Python" };
        List<string> technologies = new List<string>() {  "ASP .Net Core", "Angular", "C#", "React",  "Sql" };

        var result = programmingLangs.Except(technologies);
        //.Except() returns elements that are just in first list,in this case first list is programmingLangs
    }

    public void Use_Except_Class()
    {
        List<Product> products = Product.GetProducts();
        List<Product> products2 = new List<Product>() {
        new Product() { Id = 10, Name = "iPhone 13", CategoryId = 1, Price =15000 },
        new Product() { Id = 6, Name = "Women's Jeans", CategoryId = 3, Price = 3200},
        new Product() { Id = 12, Name = "iPhone 13", CategoryId = 1, Price =15000 },
        new Product() { Id = 11, Name = "Women's T-Shirt", CategoryId = 3, Price = 2500},
        new Product() { Id = 9, Name = "Jacket", CategoryId = 3, Price = 1000},
    };
        var result = products.Except(products2, new ProductComparer());
        //because .Except does not know how to filter classes, we need to create a class of type IEqualityComparer

        foreach (var item in result)
        {
            Console.WriteLine(item.Name);
        }
    }
}
