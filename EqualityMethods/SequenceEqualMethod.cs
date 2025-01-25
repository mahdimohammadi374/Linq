namespace Linq.EqualityMethods;

public class SequenceEqualMethod
{
    public void Use_SequenceEqual()
    {
        var list1 = new List<int>() { 1,4,9};
        var list2 = new List<int>() { 1,4,9};

        var isEqual = list1.SequenceEqual(list2); //How we compare 2 Lists

        var product1 = Product.GetProducts();
        var product2 = Product.GetProducts();

        var IsEqualClasses = product1.SequenceEqual(product2, new ProductComparer()); //How we compare 2 Lists of objects
    }
}
