using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebCoreAP.Models;

namespace WebCoreAP.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EnderecoCobrancaController : ControllerBase
    {
        private readonly APContext _context;

        public EnderecoCobrancaController(APContext context)
        {
            _context = context;
        }

        // GET: api/EnderecoCobranca
        [HttpGet]
        public async Task<ActionResult<IEnumerable<EnderecoCobranca>>> GetEnderecosCobranca()
        {
            return await _context.EnderecosCobranca.ToListAsync();
        }

        // GET: api/EnderecoCobranca/5
        [HttpGet("{id}")]
        public async Task<ActionResult<EnderecoCobranca>> GetEnderecoCobranca(int id)
        {
            var enderecoCobranca = await _context.EnderecosCobranca.FindAsync(id);

            if (enderecoCobranca == null)
            {
                return NotFound();
            }

            return enderecoCobranca;
        }

        // PUT: api/EnderecoCobranca/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutEnderecoCobranca(int id, EnderecoCobranca enderecoCobranca)
        {
            if (id != enderecoCobranca.EnderecoId)
            {
                return BadRequest();
            }

            _context.Entry(enderecoCobranca).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EnderecoCobrancaExists(id))
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

        // POST: api/EnderecoCobranca
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<EnderecoCobranca>> PostEnderecoCobranca(EnderecoCobranca enderecoCobranca)
        {
            _context.EnderecosCobranca.Add(enderecoCobranca);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetEnderecoCobranca", new { id = enderecoCobranca.EnderecoId }, enderecoCobranca);
        }

        // DELETE: api/EnderecoCobranca/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<EnderecoCobranca>> DeleteEnderecoCobranca(int id)
        {
            var enderecoCobranca = await _context.EnderecosCobranca.FindAsync(id);
            if (enderecoCobranca == null)
            {
                return NotFound();
            }

            _context.EnderecosCobranca.Remove(enderecoCobranca);
            await _context.SaveChangesAsync();

            return enderecoCobranca;
        }

        private bool EnderecoCobrancaExists(int id)
        {
            return _context.EnderecosCobranca.Any(e => e.EnderecoId == id);
        }
    }
}
