namespace Linq.ElementMethods;

public class SingleMethod
{
    public void Use_Single()
    {
        List<Product> products = Product.GetProducts();

        products.Single(x => x.Price > 10000);
        //it returns the only elemant that matches condition.if there is more than one element throws InvalidOperationException
        //if there is not specified any condition and if there is only one element in list, returns that element. else throws InvalidOperationException
        //if there is no element matches condition throws InvalidOperationException
    }
}
