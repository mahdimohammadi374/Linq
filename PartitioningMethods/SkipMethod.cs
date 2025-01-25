namespace Linq.PartitioningMethods;

public class SkipMethod
{
    public void Use_Skip()
    {
        List<Product> products = Product.GetProducts();

        var records = products.Skip(3); 
    }
}
