namespace Linq.ProjectionMethods;

public class SelectManyMethod
{
    public void Use_SelectMany()
    {
        List<Category> data = Category.GetCategoryWithProducts();

        var result = data.SelectMany(x => x.Products.Where(p => p.Price < 12000).Select(x=>
        new 
        {
            ProductName = x.Name,
            Price = x.Price,
        }
        ));
    }
}
