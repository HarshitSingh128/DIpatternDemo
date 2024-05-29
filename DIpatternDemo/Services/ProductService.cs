using DIpatternDemo.Models;
using DIpatternDemo.Repositories;

namespace DIpatternDemo.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository repo;
        public ProductService(IProductRepository repo)
        {
            this.repo = repo;
        }
        public int AddProduct(Product1 pd)
        {
            return 
        }

        public int DeleteProduct(int id)
        {
            
        }

        public int EditProduct(Product1 pd)
        {
            
        }

        public Product1 GetProductById(int id)
        {
            
        }

        public IEnumerable<Product1> GetProducts()
        {
            
        }
    }
}
