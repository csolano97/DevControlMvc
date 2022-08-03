using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using DevControlM.Models;

namespace DevControlM.Apis
{
    [Route("api/[controller]")]
    [ApiController]
    public class CentrosController : ControllerBase
    {
        private readonly DevControlContext _context;

        public CentrosController(DevControlContext context)
        {
            _context = context;
        }

        // GET: api/Centros
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Establecimientos>>> GetEstablecimientos()
        {
            return await _context.Establecimientos.ToListAsync();
        }

        // GET: api/Centros/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Establecimientos>> GetEstablecimientos(int id)
        {
            var establecimientos = await _context.Establecimientos.FindAsync(id);

            if (establecimientos == null)
            {
                return NotFound();
            }

            return establecimientos;
        }

        // PUT: api/Centros/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutEstablecimientos(int id, Establecimientos establecimientos)
        {
            if (id != establecimientos.Id)
            {
                return BadRequest();
            }

            _context.Entry(establecimientos).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EstablecimientosExists(id))
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

        // POST: api/Centros
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Establecimientos>> PostEstablecimientos(Establecimientos establecimientos)
        {
            _context.Establecimientos.Add(establecimientos);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetEstablecimientos", new { id = establecimientos.Id }, establecimientos);
        }

        // DELETE: api/Centros/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteEstablecimientos(int id)
        {
            var establecimientos = await _context.Establecimientos.FindAsync(id);
            if (establecimientos == null)
            {
                return NotFound();
            }

            _context.Establecimientos.Remove(establecimientos);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool EstablecimientosExists(int id)
        {
            return _context.Establecimientos.Any(e => e.Id == id);
        }
    }
}
