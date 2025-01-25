namespace Linq.ElementMethods;

public class LastMethod
{
    public void Use_Last()
    {
        List<Product> products = Product.GetProducts();

        products.Last(x => x.Price > 10000);//it returns the last elemant that matches condition. if there is not specified any condition it returns last element of list
        //if there is no element matches condition throws InvalidOperationException
    }
}
