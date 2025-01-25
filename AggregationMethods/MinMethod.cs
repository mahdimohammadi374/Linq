namespace Linq.AggregationMethods;

public class MinMethod
{
    public void Use_Min()
    {
        List<Product> products = Product.GetProducts();
        if (products is not null) // if list is null throws InvalidOperationException
        {
            var result = products.Min(x => x.Price).ToString();
            //result is Lowest price
            Console.WriteLine(result);
        }

    }
}
