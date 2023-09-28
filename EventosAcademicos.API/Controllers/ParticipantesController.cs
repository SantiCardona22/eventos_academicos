using EventosAcademicos.API.Data;
using EventosAcademicos.Library.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics.Metrics;

namespace EventosAcademicos.API.Controllers
{
    [ApiController]
    [Route("/api/participants")]
    public class ParticipantesController : ControllerBase
    {
        private readonly DataContext _context;

        public ParticipantesController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult> Get()
        {
            return Ok(await _context.Participantes.ToListAsync());
        }


        //Get por parámetro--- id

        [HttpGet("{id:int}")]
        public async Task<ActionResult> Get(int id)
        {

            var eventAca = await _context.Participantes.FirstOrDefaultAsync(c => c.Id == id);

            if (eventAca == null)
            {
                return NotFound();//404
            }

            return Ok(eventAca);//200

        }

        // Insertar registros

        [HttpPost]
        public async Task<ActionResult> Post(Participantes parti)
        {
            _context.Add(parti);
            await _context.SaveChangesAsync();
            return Ok(parti);//200
        }



        [HttpPut]
        public async Task<ActionResult> Put(Participantes parti)
        {
            _context.Update(parti);
            await _context.SaveChangesAsync();
            return Ok(parti);//200
        }

        [HttpDelete("{id:int}")]
        public async Task<ActionResult> Delete(int id)
        {

            var filaafectada = await _context.Participantes
                .Where(c => c.Id == id)
                .ExecuteDeleteAsync();

            if (filaafectada == 0)
            {
                return NotFound();// 404
            }

            return NoContent();//204   
        }
    }
}
