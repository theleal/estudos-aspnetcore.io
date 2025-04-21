using DemoASPNETCoreWebAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace DemoASPNETCoreWebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class StudentController : ControllerBase
    {
        [HttpGet("GetStudents")]
        public Student GetStudents()
        {
            return new Student
            {
                Id = 1,
                Active = true,
                DateRegister = DateTime.Now,
                Email = "demoAPI@gmail.com",
                Name = "thelal"
            };
        }
    }
}
