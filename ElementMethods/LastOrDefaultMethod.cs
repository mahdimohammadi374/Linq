namespace Linq.ElementMethods;

public class LastOrDefaultMethod
{
    public void Use_LastOrDefault()
    {
        List<Product> products = Product.GetProducts();

        products.LastOrDefault(x => x.Price > 10000);//it returns the last elemant that matches condition. if there is not specified any condition it returns last element of list
        //if there is no element matches condition returns default value
    }
}
