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
    public class EnderecoInstalacaoController : ControllerBase
    {
        private readonly APContext _context;

        public EnderecoInstalacaoController(APContext context)
        {
            _context = context;
        }

        // GET: api/EnderecoInstalacao
        [HttpGet]
        public async Task<ActionResult<IEnumerable<EnderecoInstalacao>>> GetEnderecosInstalacao()
        {
            return await _context.EnderecosInstalacao.ToListAsync();
        }

        // GET: api/EnderecoInstalacao/5
        [HttpGet("{id}")]
        public async Task<ActionResult<EnderecoInstalacao>> GetEnderecoInstalacao(int id)
        {
            var enderecoInstalacao = await _context.EnderecosInstalacao.FindAsync(id);

            if (enderecoInstalacao == null)
            {
                return NotFound();
            }

            return enderecoInstalacao;
        }

        // PUT: api/EnderecoInstalacao/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutEnderecoInstalacao(int id, EnderecoInstalacao enderecoInstalacao)
        {
            if (id != enderecoInstalacao.EnderecoId)
            {
                return BadRequest();
            }

            _context.Entry(enderecoInstalacao).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EnderecoInstalacaoExists(id))
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

        // POST: api/EnderecoInstalacao
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<EnderecoInstalacao>> PostEnderecoInstalacao(EnderecoInstalacao enderecoInstalacao)
        {
            _context.EnderecosInstalacao.Add(enderecoInstalacao);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetEnderecoInstalacao", new { id = enderecoInstalacao.EnderecoId }, enderecoInstalacao);
        }

        // DELETE: api/EnderecoInstalacao/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<EnderecoInstalacao>> DeleteEnderecoInstalacao(int id)
        {
            var enderecoInstalacao = await _context.EnderecosInstalacao.FindAsync(id);
            if (enderecoInstalacao == null)
            {
                return NotFound();
            }

            _context.EnderecosInstalacao.Remove(enderecoInstalacao);
            await _context.SaveChangesAsync();

            return enderecoInstalacao;
        }

        private bool EnderecoInstalacaoExists(int id)
        {
            return _context.EnderecosInstalacao.Any(e => e.EnderecoId == id);
        }
    }
}
