namespace Linq.QualifireMethods;

public class ContainsMethod
{
    public void Use_ContainsMethod()
    {
        List<string> programmingLangs = new List<string>() { "C#", "Java", "Python", "Javascript", "Go"};
        bool result = programmingLangs.Contains("C++");
        //.Contains() checks if an element exists in the list
        Console.WriteLine(result);

        List<Product> products = Product.GetProducts();

        bool prod = products.Any(x => x.Name.Contains("iPhone"));
    }
}