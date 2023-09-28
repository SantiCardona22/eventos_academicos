using EventosAcademicos.API.Data;
using EventosAcademicos.Library.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics.Metrics;

namespace EventosAcademicos.API.Controllers
{
    [ApiController]
    [Route("/api/events")]
    public class EvenAcademicosController:ControllerBase
    {
            private readonly DataContext _context;

            public EvenAcademicosController(DataContext context)
            {
                _context = context;
            }


            // Lista de paises
            [HttpGet]
            public async Task<ActionResult> Get()
            {
                return Ok(await _context.EvenAcademicos.ToListAsync());
            }


            //Get por parámetro--- id

            [HttpGet("{id:int}")]
            public async Task<ActionResult> Get(int id)
            {

                var eventAca = await _context.EvenAcademicos.FirstOrDefaultAsync(c => c.Id == id);

                if (eventAca == null)
                {
                    return NotFound();//404
                }

                return Ok(eventAca);//200

            }

            // Insertar registros

            [HttpPost]
            public async Task<ActionResult> Post(EvenAcademicos eventAca)
            {
                _context.Add(eventAca);
                await _context.SaveChangesAsync();
                return Ok(eventAca);//200
            }



            [HttpPut]
            public async Task<ActionResult> Put(EvenAcademicos eventAca )
            {
                _context.Update(eventAca);
                await _context.SaveChangesAsync();
                return Ok(eventAca);//200
            }

            [HttpDelete("{id:int}")]
            public async Task<ActionResult> Delete(int id)
            {

                var filaafectada = await _context.EvenAcademicos
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
