namespace Linq.ElementMethods;

public class SingleOrDefaultMethod
{
    public void Use_SingleOrDefault()
    {
        List<Product> products = Product.GetProducts();

        products.SingleOrDefault(x => x.Price > 10000);
        //it returns the only elemant that matches condition.if there is more than one element throws InvalidOperationException
        //if there is not specified any condition and if there is only one element in list, returns that element. else throws InvalidOperationException
        //if there is no element matches condition returns default value
    }
}