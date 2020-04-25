using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CursoWebAPI.Repositories;
using CursoWebAPI.Models;

namespace CursoWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProdutosController : ControllerBase
    {
        private readonly ProdutoRepository _produtoRepos;

        public ProdutosController(ProdutoRepository produtoRepos)
        {
            _produtoRepos = produtoRepos;
        }

        // GET: api/Produtos
        [HttpGet]
        public async Task<IEnumerable<Produto>> Get()
        {
            return await _produtoRepos.ObterTodos();
        }

        // GET: api/Produtos/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Produtos
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/Produtos/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
