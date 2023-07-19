using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NIPAPI.Data.Data;
using NIPAPI.Domain.Model;

namespace NIPApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CoursesController : ControllerBase
    {
        private readonly NIPAPIDbContext _context;
        public CoursesController(NIPAPIDbContext context) 
        {
            _context = context;
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Course>>> GetCourses()
        {
            return await _context.Courses.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Course>>GetCourse(int id)
        {
            var course = await _context.Courses.FindAsync();
            return course;
        }

        [HttpPut("{id}")]
        public async Task<IActionResult>PutCourse(int id, Course course)
        {
            if(id != course.Id)
            {
                return BadRequest();
            }
            await _context.SaveChangesAsync();
            return Ok();
        }

        [HttpPost]
        public async Task<ActionResult<Course>>PostCourse(Course course)
        {
            _context.Courses.Add(course);
            await _context.SaveChangesAsync();
            return CreatedAtAction("GetCourse", new {id = course.Id}, course);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCourse(int id)
        {
            var course = await _context.Courses.FindAsync(id);
            if(course == null)
            {
                return NotFound();
            }
            _context.Courses.Remove(course);
            await _context.SaveChangesAsync();
            return NoContent();

        }
    }
}
