namespace Linq.PartitioningMethods;

public class SkipWhileMethod
{
    public void Use_SkipWhile()
    {
        List<Product> products = Product.GetProducts();
        //It will skip records with given condition but when condition is true it will return remaining records
        var records = products.SkipWhile(x=>x.Price < 20000); 
    }
}
