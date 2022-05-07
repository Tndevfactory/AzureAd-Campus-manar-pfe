
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace tracerapi.Controllers
{
    [Route("api/[controller]")]

    [ApiController]

    public class TracerController : ControllerBase
    {
        private readonly DataContext _context;

        public TracerController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<List<TracerModel>>> Get()
        {
            return Ok(await _context.TracerModels.ToListAsync());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<TracerModel>> Get(int id)
        {
            var incident = await _context.TracerModels.FindAsync(id);
            if (incident == null)
                return BadRequest("incident not found.");
            return Ok(incident);
        }

        [HttpPost]
        public async Task<ActionResult<List<TracerModel>>> AddHero(TracerModel incident)
        {
            _context.TracerModels.Add(incident);
            await _context.SaveChangesAsync();

            return Ok(await _context.TracerModels.ToListAsync());
        }

        [HttpPut]
        public async Task<ActionResult<List<TracerModel>>> UpdateHero(TracerModel request)
        {
            var dbincident = await _context.TracerModels.FindAsync(request.Id);
            if (dbincident == null)
                return BadRequest("incident not found.");

            dbincident.Name = request.Name;
            dbincident.FirstName = request.FirstName;
            dbincident.LastName = request.LastName;
            dbincident.Place = request.Place;

            await _context.SaveChangesAsync();

            return Ok(await _context.TracerModels.ToListAsync());
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<List<TracerModel>>> Delete(int id)
        {
            var dbincident = await _context.TracerModels.FindAsync(id);
            if (dbincident == null)
                return BadRequest("incident not found.");

            _context.TracerModels.Remove(dbincident);
            await _context.SaveChangesAsync();

            return Ok(await _context.TracerModels.ToListAsync());
        }

    }
}
