namespace Linq.ElementMethods;

public class ElementAtOrDefaultMethod
{
    public void Use_ElementAtOrDefault()
    {
        List<Product> products = Product.GetProducts();

        products.ElementAtOrDefault(0);//it returns the elemant at specified index. in this case index 0
        //if specifed index is out of range it returns default value. in this case null
    }
}
