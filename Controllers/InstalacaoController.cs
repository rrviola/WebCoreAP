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
    public class InstalacaoController : ControllerBase
    {
        private readonly APContext _context;

        public InstalacaoController(APContext context)
        {
            _context = context;
        }

        // GET: api/Instalacao
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Instalacao>>> GetInstalacoes()
        {
            return await _context.Instalacoes.ToListAsync();
        }

        // GET: api/Instalacao/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Instalacao>> GetInstalacao(int id)
        {
            var instalacao = await _context.Instalacoes.FindAsync(id);

            if (instalacao == null)
            {
                return NotFound();
            }

            return instalacao;
        }

        // PUT: api/Instalacao/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutInstalacao(int id, Instalacao instalacao)
        {
            if (id != instalacao.InstalacaoId)
            {
                return BadRequest();
            }

            _context.Entry(instalacao).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!InstalacaoExists(id))
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

        // POST: api/Instalacao
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Instalacao>> PostInstalacao(Instalacao instalacao)
        {
            _context.Instalacoes.Add(instalacao);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetInstalacao", new { id = instalacao.InstalacaoId }, instalacao);
        }

        // DELETE: api/Instalacao/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Instalacao>> DeleteInstalacao(int id)
        {
            var instalacao = await _context.Instalacoes.FindAsync(id);
            if (instalacao == null)
            {
                return NotFound();
            }

            _context.Instalacoes.Remove(instalacao);
            await _context.SaveChangesAsync();

            return instalacao;
        }

        private bool InstalacaoExists(int id)
        {
            return _context.Instalacoes.Any(e => e.InstalacaoId == id);
        }
    }
}
