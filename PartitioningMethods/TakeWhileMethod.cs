namespace Linq.PartitioningMethods;

public class TakeWhileMethod
{
    public void Use_TakeWhile()
    {
        List<Product> products = Product.GetProducts();
        //It will return records with given condition but when condition is true it wont return remaining records
        var records = products.TakeWhile(x => x.Price < 20000);
    }
}