namespace Linq.GenerationMethods;

public class EmptyMethod
{
    public void Use_Empty()
    {
        //creates an empty list of given type
        IEnumerable<Product> emptyList = Enumerable.Empty<Product>();
    }
}
