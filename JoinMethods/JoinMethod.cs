namespace Linq.JoinMethods;

public class JoinMethod
{
    public void Use_Join()
    {
        List<Category> categories = Category.GetCategories();
        List<Product> products = Product.GetProducts();

        IEnumerable<Product> result = products.Join(categories, x => x.CategoryId, x => x.Id, (product, category) =>
          new Product
          {
              Id = product.Id,
              CategoryId = category.Id,
              CategoryTitle = category.Title,
              Name = product.Name,
          }
        );

        foreach (var item in result)
        {
            Console.WriteLine($"Product {item.Name} ===> Category {item.CategoryTitle}");
        }
    }
}
