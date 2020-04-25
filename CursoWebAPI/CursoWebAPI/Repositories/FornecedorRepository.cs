using CursoWebAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace CursoWebAPI.Repositories
{
    public class FornecedorRepository : Repository<Fornecedor>
    {
        public FornecedorRepository(ApiDbContext dbContext) : base(dbContext) { }
    }
}