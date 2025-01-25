namespace Linq.GenerationMethods;

public class DefaultIfEmptyMethod
{
    public void Use_DefaultIfEmpty()
    {
        List<int> emptyList = new List<int>();

        var list1 = emptyList.DefaultIfEmpty();//if emptyList is empty creates a list with a value of null [null]
        var list2 = emptyList.DefaultIfEmpty(1); //if emptyList is empty creaats a list with value 1 [1 ]
    }
}
