using DIpatternDemo.Data;
using DIpatternDemo.Models;

namespace DIpatternDemo.Repositories
{
    public class EmployeeRepository : IEmployeeRepostory

    {
        private readonly ApplicationDbContext db;
        public EmployeeRepository(ApplicationDbContext db)
        {
            this.db = db;

        }
        public int AddEmployee(Emp employee)
        {
            employee.Isactive = 1;
            int result = 0;
            db.Employees.Add(employee);
            result = db.SaveChanges();
            return result;


        }

        public int DeleteEmployee(int id)
        {
            int result = 0;
            var model = db.Employees.Where(emp => emp.Id == id).FirstOrDefault();
            if (model != null)
            {
                model.Isactive = 0;
                result = db.SaveChanges();
            }
            return result;

           
        }

        public int EditEmployee(Emp employee)
        {
            int result = 0;
            var model = db.Employees.Where(emp => emp.Id == employee.Id).FirstOrDefault();
            if (model != null)
            {
                model.Name = employee.Name;
                model.City = employee.City;
                model.Salary = employee.Salary;
                model.Isactive = 1;
                result = db.SaveChanges();
            }
            return result;

        }

        public Emp GetEmployeeById(int id)
        {
            return db.Employees.Where(x => x.Id == id).SingleOrDefault();
        }

        public IEnumerable<Emp> GetEmployees()
        {
            var model = (from emp in db.Employees
                         where emp.Isactive == 1
                         select emp).ToList();
            return model;

        }
    }
}
