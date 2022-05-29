
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using tracerapi.Models;

namespace tracerapi.Controllers
{
    [Route("api/[controller]")]

    [ApiController]

    public class InterventionController : ControllerBase
    {
        private readonly DataContext _context;

        public InterventionController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<List<Intervention>>> Get()
        {
            return Ok(await _context.Interventions.ToListAsync());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Intervention>> Get(int id)
        {
            var intervention = await _context.Interventions.FindAsync(id);
            if (intervention == null)
                return BadRequest("incident not found.");
            return Ok(intervention);
        }

        [HttpPost]
        public async Task<ActionResult<List<Intervention>>> AddIncident(Intervention intervention)
        {
            _context.Interventions.Add(intervention);
            await _context.SaveChangesAsync();

            return Ok(await _context.Interventions.ToListAsync());
        }

        [HttpPut]
        public async Task<ActionResult<List<Intervention>>> UpdateIncident(Intervention request)
        {
            var dbintervention = await _context.Interventions.FindAsync(request.Id);
            if (dbintervention == null)
                return BadRequest("incident not found.");

            dbintervention.Sujet = request.Sujet;
            dbintervention.Compte = request.Compte;
            dbintervention.DateEcheance = request.DateEcheance;
            dbintervention.DateContrat = request.DateContrat;

            await _context.SaveChangesAsync();

            return Ok(await _context.Interventions.ToListAsync());
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<List<Intervention>>> Delete(int id)
        {
            var dbincident = await _context.Interventions.FindAsync(id);
            if (dbincident == null)
                return BadRequest("incident not found.");

            _context.Interventions.Remove(dbincident);
            await _context.SaveChangesAsync();

            return Ok(await _context.Interventions.ToListAsync());
        }

    }
}
