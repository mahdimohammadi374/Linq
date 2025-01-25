namespace Linq.AggregationMethods;

public class AggretateMethod
{
    public void Use_Aggregate()
    {
        List<Product> products = Product.GetProducts();

        var result = products.Aggregate<Product, string, string>("All Products : ",
            (str, prod) => str += (prod.Name + "( " + prod.Price + " )" + " / ") , //create the string
            str=>str.Substring(0,str.Length - 2) // remove the last '/ ' char
            );

        Console.WriteLine(result);
    }
}
