using DIpatternDemo.Data;
using DIpatternDemo.Models;

namespace DIpatternDemo.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly ApplicationDbContext db;
        public ProductRepository(ApplicationDbContext db)
        {
            this.db = db;
        }
        public int AddProduct(Product1 pd)
        {
            pd.Isactive = 1;
            int result = 0;
            db.Pdt.Add(pd);
            result = db.SaveChanges();
            return result;
        }

        public int DeleteProduct(int id)
        {
            int result = 0;
            var model = db.Pdt.Where(emp => emp.Id == id).FirstOrDefault();
            if (model != null)
            {
                model.Isactive = 0;
                result = db.SaveChanges();
            }
            return result;
        }

        public int EditProduct(Product1 pd)
        {
            int result = 0;
            var model = db.Pdt.Where(emp => emp.Id == pd.Id).FirstOrDefault();
            if (model != null)
            {
                model.Name = pd.Name;
                model.Price = pd.Price;
                model.Isactive = 1;
                result = db.SaveChanges();
            }
            return result;
        }

        public Product1 GetProductById(int id)
        {
            return db.Pdt.Where(x => x.Id == id).SingleOrDefault();
        }

        public IEnumerable<Product1> GetProducts()
        {
            var model = (from emp in db.Pdt
                         where emp.Isactive == 1
                         select emp).ToList();
            return model;

        }
    }
}
