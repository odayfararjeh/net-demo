using ConsoleApp2;
using ConsoleApp2.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController(IDataService dataservice) : ControllerBase
    {
        private readonly IDataService _dataservice = dataservice;

        [Route("GetData")]
        public ActionResult GetData()
        {
            string result = _dataservice.GetData();
            return Ok(result);
        }

        [HttpGet]
        public ActionResult AddNumbers(int a, int b)
        {
            int result = _dataservice.AddNumbers(a, b);
            return Ok(result);
        }
    }
}
