namespace Linq.PartitioningMethods;

public class TakeMethod
{
    public void Use_Take()
    {
        List<Product> products = Product.GetProducts();

        var records = products.Take(3);
    }
}
