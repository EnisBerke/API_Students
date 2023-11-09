using API_w_Mongo.Domain.Models;
using API_w_Mongo.Applicaiton;
using API_w_Mongo.Applicaiton.Services;
using Microsoft.AspNetCore.Mvc;
using API_w_Mongo.Application.Services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace API_w_Mongo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        public IStudentServices studentService { get; }

        public StudentsController(IStudentServices studentService)
        {
            this.studentService = studentService;
        }

        // GET: api/<ValuesController>

        [HttpGet]
        public ActionResult<List<Student>> Get(StudentServices studentServices)
        {
            return studentServices.Get();
        }

        // GET api/<ValuesController>/5
        [HttpGet("{id}")]
        public ActionResult<Student> Get(string id)
        {

            var student = studentService.Get(id);

            if (student == null)
            {
                return NotFound($"Student with Id = {id} not found");
            }

            return Ok(student);
        }

        // POST api/<ValuesController>
        [HttpPost]
        public ActionResult<Student> Post([FromBody] Student student)
        {
            studentService.Create(student);

            return CreatedAtAction(nameof(Get), new { id = student.Id }, student);
        }

        // PUT api/<ValuesController>/5
        [HttpPut("{id}")]
        public ActionResult Put(string id, [FromBody] Student student)
        {
            var existingStudent = studentService.Get(id);

            if (existingStudent == null)
            {
                return NotFound($"Student with Id = {id} not found");
            }

            studentService.Update(id, student);

            return NoContent();
        }

        // DELETE api/<ValuesController>/5
        [HttpDelete("{id}")]
        public ActionResult Delete(string id)
        {
            var student = studentService.Get(id);

            if (student == null)
            {
                return NotFound($"Student with Id = {id} not found");
            }

            studentService.Remove(student.Id);

            return Ok($"Student with Id = {id} deleted");
        }

    }
}
