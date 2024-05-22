using DIpatternDemo.Data;
using DIpatternDemo.Models;

namespace DIpatternDemo.Repositories
{
    public class StudentRepository : IStudentRepository
    {
        private readonly ApplicationDbContext db;
        public StudentRepository(ApplicationDbContext db)
        {
            this.db = db;
        }
        public int AddStudent(Student1 st)
        {
            st.Isactive = 1;
            int result = 0;
            db.Stud.Add(st);
            result = db.SaveChanges();
            return result;
        }
        public int DeleteStudent(int id)
        {
            int result = 0;
            var model = db.Stud.Where(emp => emp.Sid == id).FirstOrDefault();
            if (model != null)
            {
                model.Isactive = 0;
                result = db.SaveChanges();
            }
            return result;
        }

        public int EditStudent(Student1 st)
        {

            int result = 0;
            var model = db.Stud.Where(emp => emp.Sid == st.Sid).FirstOrDefault();
            if (model != null)
            {

                model.Sname = st.Sname;
                model.Sage = st.Sage;
                model.Semail = st.Semail;
                model.Isactive = 1;
                result = db.SaveChanges();
            }
            return result;

        }
        public Student1 GetStudentById(int id)
        {

            return db.Stud.Where(x => x.Sid == id).SingleOrDefault();
        }

        public IEnumerable<Student1> GetStudents()
        {
            var model = (from emp in db.Stud
                         where emp.Isactive == 1
                         select emp).ToList();
            return model;
        }
    }
}
