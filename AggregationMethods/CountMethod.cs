namespace Linq.AggregationMethods;

public class CountMethod
{
    public void Use_Count()
    {
        List<Product> products = Product.GetProducts();

        int result = products.Count(); //.Count() returns of type int. if our list has more than int.MaxValue (2147483647) items we will get Exception
        Console.WriteLine(result);
        
        long longResult = products.LongCount(); //.LongCount() returns long and supports long.MaxValue items in list
        Console.WriteLine(longResult);
    }
}
