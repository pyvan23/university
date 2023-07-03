using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using university_api_backend.DataAccess;
using university_api_backend.Models.DataModels;

namespace university_api_backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CapitulosController : ControllerBase
    {
        private readonly UniversityDBContext _context;

        public CapitulosController(UniversityDBContext context)
        {
            _context = context;
        }

        // GET: api/Capitulos
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Capitulo>>> GetCapitulos()
        {
          if (_context.Capitulos == null)
          {
              return NotFound();
          }
            return await _context.Capitulos.ToListAsync();
        }

        // GET: api/Capitulos/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Capitulo>> GetCapitulo(int id)
        {
          if (_context.Capitulos == null)
          {
              return NotFound();
          }
            var capitulo = await _context.Capitulos.FindAsync(id);

            if (capitulo == null)
            {
                return NotFound();
            }

            return capitulo;
        }

        // PUT: api/Capitulos/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCapitulo(int id, Capitulo capitulo)
        {
            if (id != capitulo.Id)
            {
                return BadRequest();
            }

            _context.Entry(capitulo).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CapituloExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Capitulos
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Capitulo>> PostCapitulo(Capitulo capitulo)
        {
          if (_context.Capitulos == null)
          {
              return Problem("Entity set 'UniversityDBContext.Capitulos'  is null.");
          }
            _context.Capitulos.Add(capitulo);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetCapitulo", new { id = capitulo.Id }, capitulo);
        }

        // DELETE: api/Capitulos/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCapitulo(int id)
        {
            if (_context.Capitulos == null)
            {
                return NotFound();
            }
            var capitulo = await _context.Capitulos.FindAsync(id);
            if (capitulo == null)
            {
                return NotFound();
            }

            _context.Capitulos.Remove(capitulo);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool CapituloExists(int id)
        {
            return (_context.Capitulos?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
