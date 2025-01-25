namespace Linq.QualifireMethods;

public class AllMethod
{
    public void Use_AllMethod()
    {
        List<Product> products = Product.GetProducts();

        bool result = products.All(x => x.Price < 1000);
        //.All() checks a condition for all items and if that condition is true for all items it return true else returns false
        Console.WriteLine(result);
    }
}
