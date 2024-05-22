using DIpatternDemo.Models;
using DIpatternDemo.Repositories;

namespace DIpatternDemo.Services
{
    public class StudentService : IStudentService
    {
        private readonly IStudentRepository repo;

        public StudentService(IStudentRepository repo)
        {
            this.repo = repo;
        }
        public int AddStudent(Student1 st)
        {
           return repo.AddStudent(st);
        }

        public int DeleteStudent(int id)
        {
            return repo.DeleteStudent(id);
        }

        public int EditStudent(Student1 st)
        {
            return repo.EditStudent(st);
        }

        public Student1 GetStudentById(int id)
        {
            return repo.GetStudentById(id);
        }

        public IEnumerable<Student1> GetStudents()
        {
           return repo.GetStudents();
        }
    }
}
