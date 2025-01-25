namespace Linq.AggregationMethods;

public class AverageMethod
{
    public void Use_Average()
    {
        List<Product> products = Product.GetProducts();
        if(products is not null) // if list is null throws InvalidOperationException
        {
            var result = products.Average(x => x.Price).ToString();
            //result is average of all products price
            Console.WriteLine(result);
        }
    }
}
