using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NIPAPI.Data.Data;

namespace NIPApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RegistrationsController : ControllerBase
    {
        private readonly NIPAPIDbContext _context;

        public RegistrationsController(NIPAPIDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Registration>>> GetAllRegistrations()
        {
            return await _context.Registrations.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Registration>> GetRegistration(int id)
        {
            var hotel=  await _context.Registrations.FindAsync(id);
            return Ok(hotel);
        }
        [HttpPut("{id}")]
        public async Task<IActionResult> PutRegistration(Registration registration, int id)
        {
            _context.Entry(registration).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return Ok(registration);
        }

        [HttpPost]
        public async Task<ActionResult<Registration>> PostRegistration(Registration registration)
        {
            _context.Registrations.Add(registration);
            await _context.SaveChangesAsync();
            return CreatedAtAction("GetRegistration", new {id = registration.Id}, registration);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteRegistration(int id)
        {
            var registration = await _context.Registrations.FindAsync(id);
            return NoContent();
        }

        private bool RegistrationExist(int id)
        {
            return _context.Registrations.Any(e=>e.Id == id);
        }
    }
}
