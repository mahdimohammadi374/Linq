namespace Linq.ProjectionMethods;

public class SelectMethod
{
    public void Use_Select()
    {
        List<Product> products = Product.GetProducts();
        List<Category> categories = Category.GetCategories();

        IEnumerable<Product> result = products.Join(categories, x => x.CategoryId, x => x.Id, (product, category) =>
              new Product
              {
                  Id = product.Id,
                  CategoryId = category.Id,
                  CategoryTitle = category.Title,
                  Name = product.Name,
              }
            );


        //we can select jus that data that we need
        List<ProductDTO> resultDTO = result.Select(x => new ProductDTO 
        { 
            ProductName = x.Name,
            CategoryName = x.CategoryTitle
        }).ToList();
    }
}
