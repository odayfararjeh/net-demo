namespace DBRepository.Interfaces
{
    public interface IStudentRepository
    {
        int AddStudent(Student student);
        List<Student> GetAllStudents();
        Student? GetStudentById(int id);
        bool UpdateStudent(Student student);
        bool DeleteStudent(int id);
    }
}
