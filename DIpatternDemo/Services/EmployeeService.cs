using DIpatternDemo.Models;
using DIpatternDemo.Repositories;

namespace DIpatternDemo.Services
{
    public class EmployeeService : IEmployeeService
    {
        private readonly IEmployeeRepostory repo;
        public EmployeeService(IEmployeeRepostory repo)
        {
            this.repo = repo;
        }
        public int AddEmployee(Emp employee)
        {
            return repo.AddEmployee(employee);
        }

        public int DeleteEmployee(int id)
        {
            return repo.DeleteEmployee(id);
        }

        public int EditEmployee(Emp employee)
        {
            return repo.EditEmployee(employee);
        }

        public Emp GetEmployeeById(int id)
        {
            return repo.GetEmployeeById(id);
        }

        public IEnumerable<Emp> GetEmployees()
        {
           return repo.GetEmployees();
        }
    }
}
