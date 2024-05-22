using DIpatternDemo.Models;

namespace DIpatternDemo.Services
{
    public interface IEmployeeService
    {
        IEnumerable<Emp> GetEmployees();

        Emp GetEmployeeById(int id);
        int AddEmployee(Emp employee);
        int EditEmployee(Emp employee);
        int DeleteEmployee(int id);
    }
}
