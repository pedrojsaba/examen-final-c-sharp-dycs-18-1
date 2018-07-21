using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApi.Controllers
{
    public class StudentController : ApiController
    {
        IStudent _student;
        StudentController() {
            _student = new Undergraduate();
        }
        [HttpGet]
        [Route("api/students/{id}")]
        public List<string> List(int id)
        {
            return _student.View();
        }

        [HttpGet]
        [Route("api/students/{id}/calculate")]
        public IEnumerable<string> Calculate(int id)
        {
            return new string[] { "1", "2" };
        }
    }
}
