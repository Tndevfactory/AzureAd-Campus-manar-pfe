
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using tracerapi.Models;

namespace tracerapi.Controllers
{
    [Route("api/[controller]")]

    [ApiController]

    public class TacheController : ControllerBase
    {
        private readonly DataContext _context;

        public TacheController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<List<Tache>>> Get()
        {
            return Ok(await _context.Taches.ToListAsync());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Tache>> Get(int id)
        {
            var tache = await _context.Taches.FindAsync(id);
            if (tache == null)
                return BadRequest("incident not found.");
            return Ok(tache);
        }

        [HttpPost]
        public async Task<ActionResult<List<Tache>>> AddIncident(Tache tache)
        {
            _context.Taches.Add(tache);
            await _context.SaveChangesAsync();

            return Ok(await _context.Taches.ToListAsync());
        }

        [HttpPut]
        public async Task<ActionResult<List<Tache>>> UpdateIncident(Tache request)
        {
            var dbtache = await _context.Taches.FindAsync(request.Id);
            if (dbtache == null)
                return BadRequest("tache not found.");

            dbtache.Sujet = request.Sujet;
            dbtache.DateEcheance = request.DateEcheance;
            dbtache.DateContrat = request.DateContrat;
            dbtache.Compte = request.Compte;

            await _context.SaveChangesAsync();

            return Ok(await _context.Taches.ToListAsync());
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<List<Tache>>> Delete(int id)
        {
            var dbtache = await _context.Taches.FindAsync(id);
            if (dbtache == null)
                return BadRequest("incident not found.");

            _context.Taches.Remove(dbtache);
            await _context.SaveChangesAsync();

            return Ok(await _context.Taches.ToListAsync());
        }

    }
}
