namespace Linq.ElementMethods;

public class ElementAtMethod
{
    public void Use_ElementAt()
    {
        List<Product> products = Product.GetProducts();

        products.ElementAt(0);//it returns the elemant at specified index. in this case index 0
        //if specifed index is out of range it throws ArgumentOutOfRangeException
    }
}
