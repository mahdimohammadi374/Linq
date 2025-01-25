namespace Linq.QualifireMethods;

public class AnyMethod
{
    public void Use_AnyMethod()
    {
        List<Product> products = Product.GetProducts();

        bool result = products.Any(x => x.Price < 30000);
        //.Any() checks a condition for all items and if that condition is true for one or more items it return true else returns false

        bool result2 = products.Any();
        //if dont pass any condition it will return true when there is atleast one element in list
        Console.WriteLine(result);
    }
}
