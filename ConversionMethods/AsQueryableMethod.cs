namespace Linq.ConversionMethods;

public class AsQueryableMethod
{
    public void Use_AsQueryable()
    {
        var productArray = Product.GetProductsArray();

        IQueryable<Product> products = productArray.AsQueryable();
    }
}
