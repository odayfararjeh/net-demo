using DBRepository;
using DBRepository.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SchoolController : ControllerBase
    {
        private readonly ISchoolRepository _schoolRepository;
        public SchoolController(ISchoolRepository schoolRepository)
        {
            _schoolRepository = schoolRepository;
        }

        [HttpPost("AddSchool")]
        public IActionResult AddSchool(School school)
        {
            int result = _schoolRepository.AddSchool(school);
            if (result > 0)
                return Ok("School added successfully.");
            else
                return BadRequest("Failed to add school.");
        }
    }
}
