using CursoWebAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace CursoWebAPI.Repositories
{
    public class ProdutoRepository : Repository<Produto>
    {
        public ProdutoRepository(ApiDbContext dbContext) : base(dbContext) { }
    }
}