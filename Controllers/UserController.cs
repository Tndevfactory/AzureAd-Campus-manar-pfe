
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using tracerapi.Models;

namespace tracerapi.Controllers
{
    [Route("api/[controller]")]

    [ApiController]

    public class UserController : ControllerBase
    {
        private readonly DataContext _context;

        public UserController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<List<User>>> Get()
        {
            return Ok(await _context.Users.ToListAsync());
        }

        [HttpGet("{username}")]
        public async Task<ActionResult<User>> Get(string username)
        {
            var user = await _context.Users.FindAsync(username);
            if (user == null)
                return BadRequest("user not found.");
            return Ok(user);
        }

        [HttpPost]
        public async Task<ActionResult<List<User>>> AddEvent(User user)
        {
            _context.Users.Add(user);
            await _context.SaveChangesAsync();

            return Ok(await _context.Users.ToListAsync());
        }

        [HttpPut]
        public async Task<ActionResult<List<User>>> UpdateEvent(User request)
        {
            var user = await _context.Users.FindAsync(request.Username);
            if (user == null)
                return BadRequest("user not found.");

            
            user.Username = request.Username;
            

            await _context.SaveChangesAsync();

            return Ok(await _context.Users.ToListAsync());
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<List<User>>> Delete(string Username)
        {
            var user = await _context.Users.FindAsync(Username);
            if (user == null)
                return BadRequest("user not found.");

            _context.Users.Remove(user);
            await _context.SaveChangesAsync();

            return Ok(await _context.Users.ToListAsync());
        }

    }
}
