namespace Linq.ElementMethods;

public class FirstOrDefaultMethod
{
    public void Use_FirstOrDefault()
    {
        List<Product> products = Product.GetProducts();

        products.FirstOrDefault(x => x.Price > 10000);//it returns the first elemant that matches condition. if there is not specified any condition it returns first element of list
        //if there is no element matches condition returns default value
    }
}
