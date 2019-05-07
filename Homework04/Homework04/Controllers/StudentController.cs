using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Homework04.Controllers
{
    // create a new class "Student" here
    public class Student
    {
        public string ID { get; set; }
        public string name { get; set; }
    }

    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        // GET api/Student
        [HttpGet]
        public ActionResult<IEnumerable<Student>> Get()
        {
            // create a new little database (a list of students) here
            return new List<Student> {
                new Student{ID = "3017218197", name = "Liu Yuanefeng" },
                new Student{ID = "3017218198", name = "Lu Yuan" },
                new Student{ID = "3017218199", name = "Lv Manying"}
            };
        }

        // GET api/Student/5
        [HttpGet("{id}")]
        public ActionResult<Student> Get(int id)
        {
            // create a new instance of student here
            return new Student { ID = "3017218196", name = "Liu Huiyu" };
        }

        // POST api/Student
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/Student/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/Student/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
