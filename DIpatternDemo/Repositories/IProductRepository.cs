using DIpatternDemo.Models;

namespace DIpatternDemo.Repositories
{
    public interface IProductRepository
    {
        IEnumerable<Product1> GetProducts();

        Product1 GetProductById(int id);
        int AddProduct(Product1 pd);
        int EditProduct(Product1 pd);
        int DeleteProduct(int id);
    }
}
