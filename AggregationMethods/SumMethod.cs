namespace Linq.AggregationMethods;

public class SumMethod
{
    public void Use_Sum()
    {
        List<Product> products = Product.GetProducts();

        var result = products.Sum(x => x.Price).ToString();
        //result is Sum of all products price
        Console.WriteLine(result);
    }
}