using Catalogo_Blazor.Server.Context;
using Catalogo_Blazor.Shared.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Catalogo_Blazor.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriaController : ControllerBase
    {
        private readonly AppDbContext _context;
        public CategoriaController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet("todas")]
        public async Task<ActionResult<List<Categoria>>> Get()
        {
            return await _context.Categorias.AsNoTracking().ToListAsync();
        }

        [HttpGet("{id}", Name ="GetCategoria")]
        public async Task<ActionResult<Categoria>> GetById(int id)
        {
            return await _context.Categorias.FirstOrDefaultAsync(c=>c.CategoriaId == id);
        }

        [HttpPost]

        public async Task<ActionResult<Categoria>> Post(Categoria categoria)
        {
            _context.Add(categoria);
            await _context.SaveChangesAsync();
            return new CreatedAtRouteResult("GetCategoria",
                new {id = categoria.CategoriaId}, categoria);
        }

        [HttpPut]
        public async Task<ActionResult<Categoria>> Put(Categoria categoria)
        {
            _context.Entry(categoria).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return Ok(categoria);
        }
        
        [HttpDelete("{id}")]
        public async Task<ActionResult<Categoria>> Delete(int id)
        {
            var categoria = new Categoria { CategoriaId = id};
            _context.Remove(categoria);
            await _context.SaveChangesAsync();
            return Ok(categoria);
        }
    }
}
