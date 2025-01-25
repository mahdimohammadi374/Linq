namespace Linq.ElementMethods;

public class FirstMethod
{
    public void Use_Frist()
    {
        List<Product> products = Product.GetProducts();

        products.First(x=>x.Price > 10000);//it returns the first elemant that matches condition. if there is not specified any condition it returns first element of list
        //if there is no element matches condition throws InvalidOperationException
    }
}
