namespace Linq.ConversionMethods;

public class CastMethod
{
    public void Use_Cast()
    {
        var productArray = Product.GetProductsArray();

        IEnumerable<Product> products = productArray.Cast<Product>();
    }
}
