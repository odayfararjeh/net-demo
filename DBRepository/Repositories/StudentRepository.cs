using DBRepository.Interfaces;

namespace DBRepository.Repositories
{
    public class StudentRepository : IStudentRepository
    {
        private readonly AppDbContext _appDbContext;

        public StudentRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public int AddStudent(Student student)
        {
            _appDbContext.Student.Add(student);
            return _appDbContext.SaveChanges();
        }

        public List<Student> GetAllStudents()
        {
            return _appDbContext.Student.ToList();
        }

        public Student? GetStudentById(int id)
        {
            return _appDbContext.Student.FirstOrDefault(s => s.ID == id);
        }

        public bool UpdateStudent(Student student)
        {
            _appDbContext.Student.Update(student);
            Student? existingStudent = _appDbContext.Student.FirstOrDefault(s => s.ID == student.ID);
            if(existingStudent == null)
                return false;

            existingStudent.Name = student.Name;
            existingStudent.Age = student.Age;
            existingStudent.SchoolId = student.SchoolId;
            existingStudent.Gender = student.Gender;
            _appDbContext.SaveChanges();

            return true;
        }

        public bool DeleteStudent(int id)
        {
            Student? student = _appDbContext.Student.FirstOrDefault(s => s.ID == id);
            if (student == null)
                return false;

            _appDbContext.Student.Remove(student);
            _appDbContext.SaveChanges();
            return true;
        }
    }
}
