namespace Linq.ConversionMethods;

public class AsEnumerableMethod
{
    public void Use_AsEnumerable()
    {
        var productArray = Product.GetProductsArray();

        IEnumerable<Product> products = productArray.AsEnumerable();
    }
}
