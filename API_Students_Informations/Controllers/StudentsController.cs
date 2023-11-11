using API_Students_Informations.Domain.Models;
using API_Students_Informations.Applicaiton;
using API_Students_Informations.Applicaiton.Services;
using Microsoft.AspNetCore.Mvc;
using API_Students_Informations.Application.Services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace API_Students_Informations.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        public IStudentServices _studentService { get; }

        public StudentsController(IStudentServices studentService)
        {
            _studentService = studentService;
        }

        [HttpGet("Getbylist")]
        public ActionResult<List<Student>> GetByList([FromQuery] List<string> student)
        {
            return _studentService.GetByList(student);
        }

        // GET: api/<ValuesController>

        [HttpGet("Get")]
        public ActionResult<List<Student>> GetAll()
        {
            return _studentService.GetAll();
        }

        // GET api/<ValuesController>/5
        [HttpGet("{id}")]
        public ActionResult<Student> Get(string id)
        {

            var student = _studentService.Get(id);

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
            _studentService.Create(student);

            return CreatedAtAction(nameof(Get), new { id = student.Id }, student);
        }

        // PUT api/<ValuesController>/5
        [HttpPut("{id}")]
        public ActionResult Put(string id, [FromBody] Student student)
        {
            var existingStudent = _studentService.Get(id);

            if (existingStudent == null)
            {
                return NotFound($"Student with Id = {id} not found");
            }

            _studentService.Update(id, student);

            return NoContent();
        }

        // DELETE api/<ValuesController>/5
        [HttpDelete("{id}")]
        public ActionResult Delete(string id)
        {
            var student = _studentService.Get(id);

            if (student == null)
            {
                return NotFound($"Student with Id = {id} not found");
            }

            _studentService.Remove(student.Id);

            return Ok($"Student with Id = {id} deleted");
        }

    }
}
