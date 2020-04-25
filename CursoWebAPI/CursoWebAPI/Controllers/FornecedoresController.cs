using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CursoWebAPI.Models;
using CursoWebAPI.ViewModels;
using AutoMapper;

namespace CursoWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FornecedoresController : ControllerBase
    {
        private readonly ApiDbContext _context;
        private readonly IMapper _mapper;

        public FornecedoresController(ApiDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        // GET: api/Fornecedores
        [HttpGet]
        public IEnumerable<Fornecedor> GetFornecedores()
        {
            return _context.Fornecedores;
        }

        // GET: api/Fornecedores/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetFornecedor([FromRoute] Guid id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var fornecedor = await _context.Fornecedores.FindAsync(id);

            if (fornecedor == null)
            {
                return NotFound();
            }

            return Ok(fornecedor);
        }

        // PUT: api/Fornecedores/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutFornecedor([FromRoute] Guid id, [FromBody] Fornecedor fornecedor)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != fornecedor.Id)
            {
                return BadRequest();
            }

            _context.Entry(fornecedor).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!FornecedorExists(id))
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

        // POST: api/Fornecedores
        [HttpPost]
        public async Task<IActionResult> PostFornecedor([FromBody] FornecedorViewModel vm)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var fornecedor = _mapper.Map<Fornecedor>(vm);

            _context.Fornecedores.Add(fornecedor);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetFornecedor", new { id = fornecedor.Id }, fornecedor);
        }

        // DELETE: api/Fornecedores/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteFornecedor([FromRoute] Guid id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var fornecedor = await _context.Fornecedores.FindAsync(id);
            if (fornecedor == null)
            {
                return NotFound();
            }

            _context.Fornecedores.Remove(fornecedor);
            await _context.SaveChangesAsync();

            return Ok(fornecedor);
        }

        private bool FornecedorExists(Guid id)
        {
            return _context.Fornecedores.Any(e => e.Id == id);
        }
    }
}