using EventosAcademicos.API.Data;
using EventosAcademicos.Library.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics.Metrics;

namespace EventosAcademicos.API.Controllers
{
    [ApiController]
    [Route("/api/programa")]
    public class ProgramaEventoController : ControllerBase
    {
        private readonly DataContext _context;

        public ProgramaEventoController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult> Get()
        {
            return Ok(await _context.ProgramaEvento.ToListAsync());
        }

        [HttpGet("{id:int}")]
        public async Task<ActionResult> Get(int id)
        {

            var eventoProgram = await _context.ProgramaEvento.FirstOrDefaultAsync(c => c.Id == id);

            if (eventoProgram == null)
            {
                return NotFound();
            }

            return Ok(eventoProgram);

        }

        [HttpPost]
        public async Task<ActionResult> Post(ProgramaEvento program)
        {
            _context.Add(program);
            await _context.SaveChangesAsync();
            return Ok(program);
        }

        [HttpPut]
        public async Task<ActionResult> Put(ProgramaEvento program)
        {
            _context.Update(program);
            await _context.SaveChangesAsync();
            return Ok(program);
        }

        [HttpDelete("{id:int}")]
        public async Task<ActionResult> Delete(int id)
        {

            var filaafectada = await _context.ProgramaEvento
                .Where(c => c.Id == id)
                .ExecuteDeleteAsync();

            if (filaafectada == 0)
            {
                return NotFound();
            }

            return NoContent();
        }
    }
}

