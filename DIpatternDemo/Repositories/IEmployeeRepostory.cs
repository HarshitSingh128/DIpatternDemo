using DIpatternDemo.Models;
namespace DIpatternDemo.Repositories
{
    public interface IEmployeeRepostory
    {
        IEnumerable<Emp> GetEmployees();

        Emp GetEmployeeById(int id);
        int AddEmployee(Emp employee);
        int EditEmployee(Emp employee);
        int DeleteEmployee(int id);

    }
}
