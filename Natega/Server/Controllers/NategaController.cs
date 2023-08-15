using Microsoft.AspNetCore.Mvc;
using Natega.Server.Interfaces;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Natega.Server.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class NategaController : ControllerBase
    {
        private readonly INategaInterface _nategainterface;

        public NategaController(INategaInterface nategainterface)
        {
            _nategainterface = nategainterface;
        }

        // GET: api/<NategaController>
        [HttpGet]
        public IActionResult GetAllStudents()
        {
            var results= _nategainterface.GetAllStudents();
            return Ok(results);
        }

        // GET api/<NategaController>/5
        [HttpGet("{seatingno}")]
        public IActionResult GetStudentBySeating(int seatingno)
        {
            return Ok(_nategainterface.GetStudentbyseating(seatingno));
        }

        // POST api/<NategaController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<NategaController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<NategaController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
