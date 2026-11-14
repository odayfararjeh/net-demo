using ConsoleApp2;
using ConsoleApp2.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class HomeController : Controller
    {
        private readonly IDataService _dataService;
        public HomeController(IDataService dataService)
        {
            _dataService = dataService;
        }

        [HttpPost("Get")]
        public JsonResult GetData(StudentMark studentMark)
        {
            var data = new
            {
                Name = studentMark.StudentName,
                Age = studentMark.Age,
                Email = ""
            };

            return Json(data);
        }
        
        [HttpGet("GetNew")]
        public IActionResult GetNewData(String name, int age)
        {
            var result = _dataService.GetData();
            var data = new
            {
                Name = name,
                Age = age,
                Email = ""
            };

            return BadRequest(data);
        }
    }
}
