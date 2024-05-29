using Microsoft.EntityFrameworkCore;
using DIpatternDemo.Models;
namespace DIpatternDemo.Data
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<Emp> Employees { get; set; }

        public DbSet<Student1> Stud { get; set; }

        public DbSet<Product1> Pdt{ get; set; }
    }
}
