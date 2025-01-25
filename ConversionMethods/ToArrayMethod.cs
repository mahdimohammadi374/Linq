namespace Linq.ConversionMethods;

public class ToArrayMethod
{
    public void Use_ToArray()
    {
        var products = Product.GetProducts();

        Product[] productsArray= products.ToArray();
    }
}
