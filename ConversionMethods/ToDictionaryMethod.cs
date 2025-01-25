namespace Linq.ConversionMethods;

public class ToDictionaryMethod
{
    public void Use_ToDictionary()
    {
        var products = Product.GetProducts();

        IDictionary<int, Product> keyValues = products.ToDictionary<Product, int>(x => x.Id);

        foreach (var item in keyValues.Keys)
        {
            Console.WriteLine("Key : {0} , Value : {1}",
                item, (keyValues[item] as Product).Name);
        }
    }
}