using Api.Brive.Entities;
using Brive.Api.BusinessLogic.Students;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Api.Example.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class StudentController : ControllerBase
    {
        private readonly StudentsBL studentBL;


        public StudentController()
        {
            studentBL = new StudentsBL();
        }


        [HttpGet()]

        public Task<List<Student>> Get()
        {

            return studentBL.GetStudents();

        }
    }
}
