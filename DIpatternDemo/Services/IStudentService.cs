using DIpatternDemo.Models;

namespace DIpatternDemo.Services
{
    public interface IStudentService
    {
        IEnumerable<Student1> GetStudents();

        Student1 GetStudentById(int id);
        int AddStudent(Student1 st);
        int EditStudent(Student1 st);
        int DeleteStudent(int id);
    }
}
