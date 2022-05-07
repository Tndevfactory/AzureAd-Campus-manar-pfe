
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
            var hero = await _context.TracerModels.FindAsync(id);
            if (hero == null)
                return BadRequest("Hero not found.");
            return Ok(hero);
        }

        [HttpPost]
        public async Task<ActionResult<List<TracerModel>>> AddHero(TracerModel hero)
        {
            _context.TracerModels.Add(hero);
            await _context.SaveChangesAsync();

            return Ok(await _context.TracerModels.ToListAsync());
        }

        [HttpPut]
        public async Task<ActionResult<List<TracerModel>>> UpdateHero(TracerModel request)
        {
            var dbHero = await _context.TracerModels.FindAsync(request.Id);
            if (dbHero == null)
                return BadRequest("Hero not found.");

            dbHero.Name = request.Name;
            dbHero.FirstName = request.FirstName;
            dbHero.LastName = request.LastName;
            dbHero.Place = request.Place;

            await _context.SaveChangesAsync();

            return Ok(await _context.TracerModels.ToListAsync());
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<List<TracerModel>>> Delete(int id)
        {
            var dbHero = await _context.TracerModels.FindAsync(id);
            if (dbHero == null)
                return BadRequest("Hero not found.");

            _context.TracerModels.Remove(dbHero);
            await _context.SaveChangesAsync();

            return Ok(await _context.TracerModels.ToListAsync());
        }

    }
}
