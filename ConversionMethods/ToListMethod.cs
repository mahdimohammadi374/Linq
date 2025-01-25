namespace Linq.ConversionMethods;

public class ToListMethod
{
    public void Use_ToList()
    {
        var productArray = Product.GetProductsArray();

        List<Product> products = productArray.ToList();
    }
}
