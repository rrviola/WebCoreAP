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
    public class ListaInstalacaoController : ControllerBase
    {
        private readonly APContext _context;

        public ListaInstalacaoController(APContext context)
        {
            _context = context;
        }

        // GET: api/ListaInstalacao
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ListaInstalacao>>> GetListaInstalacao()
        {
            return await _context.ListaInstalacao.ToListAsync();
        }

        // GET: api/ListaInstalacao/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ListaInstalacao>> GetListaInstalacao(int id)
        {
            var listaInstalacao = await _context.ListaInstalacao.FindAsync(id);

            if (listaInstalacao == null)
            {
                return NotFound();
            }

            return listaInstalacao;
        }

        // PUT: api/ListaInstalacao/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutListaInstalacao(int id, ListaInstalacao listaInstalacao)
        {
            if (id != listaInstalacao.ListaInstalacaoId)
            {
                return BadRequest();
            }

            _context.Entry(listaInstalacao).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ListaInstalacaoExists(id))
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

        // POST: api/ListaInstalacao
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<ListaInstalacao>> PostListaInstalacao(ListaInstalacao listaInstalacao)
        {
            _context.ListaInstalacao.Add(listaInstalacao);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetListaInstalacao", new { id = listaInstalacao.ListaInstalacaoId }, listaInstalacao);
        }

        // DELETE: api/ListaInstalacao/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<ListaInstalacao>> DeleteListaInstalacao(int id)
        {
            var listaInstalacao = await _context.ListaInstalacao.FindAsync(id);
            if (listaInstalacao == null)
            {
                return NotFound();
            }

            _context.ListaInstalacao.Remove(listaInstalacao);
            await _context.SaveChangesAsync();

            return listaInstalacao;
        }

        private bool ListaInstalacaoExists(int id)
        {
            return _context.ListaInstalacao.Any(e => e.ListaInstalacaoId == id);
        }
    }
}
