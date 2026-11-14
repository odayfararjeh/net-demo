using DBRepository;
using DBRepository.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly IStudentRepository _studentRepository;
        public StudentController(IStudentRepository studentRepository)
        {
            _studentRepository = studentRepository;
        }

        [HttpPost("Add")]
        public IActionResult AddStudent(Student student)
        {
            int result = _studentRepository.AddStudent(student);
            if (result > 0)
                return Ok("Student added successfully.");
            else
                return BadRequest("Failed to add student.");
        }

        [HttpGet("Students")]
        public IActionResult GetAllStudents()
        {
            List<Student> students = _studentRepository.GetAllStudents();
            return Ok(students);
        }

        [HttpGet("Students/{id}")]
        public IActionResult GetStudentById(int id)
        {
            Student? student = _studentRepository.GetStudentById(id);
            if (student == null)
                return NotFound("Student not found.");
            return Ok(student);
        }

        [HttpPut("Update")]
        public IActionResult UpdateStudent(Student student)
        {
            bool result = _studentRepository.UpdateStudent(student);
            if (result)
                return Ok("Student updated successfully.");
            else
                return BadRequest("Failed to update student.");
        }

        [HttpDelete("Delete/{id}")]
        public IActionResult DeleteStudent(int id)
        {
            bool result = _studentRepository.DeleteStudent(id);
            if (result)
                return Ok("Student deleted successfully.");
            else
                return BadRequest("Failed to delete student.");
        }
    }
}
