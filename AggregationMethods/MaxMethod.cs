namespace Linq.AggregationMethods;

public class MaxMethod
{
    public void Use_Max()
    {
        List<Product> products = Product.GetProducts();
        if (products is not null) // if list is null throws InvalidOperationException
        {
            var result = products.Max(x => x.Price).ToString();
            //result is Highest price
            Console.WriteLine(result);
        }

    }
}
