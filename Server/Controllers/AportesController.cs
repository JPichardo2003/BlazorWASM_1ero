using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using BlazorWASM_1ero.Server.DAL;
using BlazorWASM_1ero.Shared.Models;

namespace BlazorWASM_1ero.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AportesController : ControllerBase
    {
        private readonly Contexto _context;

        public AportesController(Contexto context)
        {
            _context = context;
        }

        // GET: api/Aportes
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Aportes>>> GetAportes()
        {
          if (_context.Aportes == null)
          {
              return NotFound();
          }
            return await _context.Aportes.ToListAsync();
        }

        // GET: api/Aportes/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Aportes>> GetAportes(int id)
        {
          if (_context.Aportes == null)
          {
              return NotFound();
          }
            var aportes = await _context.Aportes.FindAsync(id);

            if (aportes == null)
            {
                return NotFound();
            }

            return aportes;
        }

        // PUT: api/Aportes/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutAportes(int id, Aportes aportes)
        {
            if (id != aportes.AporteId)
            {
                return BadRequest();
            }

            _context.Entry(aportes).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AportesExists(id))
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

        // POST: api/Aportes
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Aportes>> PostAportes(Aportes aportes)
        {
          if (_context.Aportes == null)
          {
              return Problem("Entity set 'Contexto.Aportes'  is null.");
          }
            _context.Aportes.Add(aportes);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetAportes", new { id = aportes.AporteId }, aportes);
        }

        // DELETE: api/Aportes/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAportes(int id)
        {
            if (_context.Aportes == null)
            {
                return NotFound();
            }
            var aportes = await _context.Aportes.FindAsync(id);
            if (aportes == null)
            {
                return NotFound();
            }

            _context.Aportes.Remove(aportes);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool AportesExists(int id)
        {
            return (_context.Aportes?.Any(e => e.AporteId == id)).GetValueOrDefault();
        }
    }
}
