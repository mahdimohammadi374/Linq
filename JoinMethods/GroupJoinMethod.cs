namespace Linq.JoinMethods;

public class GroupJoinMethod
{
    public void Use_GroupJoin()
    {
        List<Category> categories = Category.GetCategories();
        List<Product> products = Product.GetProducts();

        //.GroupJoin() joins 2 datasources and then group them
        var result = categories.GroupJoin(products, c => c.Id, p => p.CategoryId, (cat, prod) =>
            new
            {
                product = prod,
                category = cat
            });

        foreach (var item in result)
        {
            Console.WriteLine($"Category {item.category.Title}");
            Console.WriteLine();
            foreach (var product in item.product)
            {
                Console.WriteLine($"Product {product.Name}");

            }

            Console.WriteLine("-------------------------------------");
        }
    }
}
