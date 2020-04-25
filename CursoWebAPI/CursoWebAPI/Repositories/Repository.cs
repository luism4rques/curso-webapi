using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using CursoWebAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace CursoWebAPI.Repositories
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : Entity, new()
    {
        protected readonly DbSet<TEntity> _DbSet;
        protected readonly ApiDbContext _DbContext;

        protected Repository(ApiDbContext dbContext)
        {
            _DbContext = dbContext;
            _DbSet = dbContext.Set<TEntity>();
        }

        public async Task Adicionar(TEntity entity)
        {
            await _DbSet.AddAsync(entity);
            await SaveChanges();
        }

        public async Task Atualizar(TEntity entity)
        {
            _DbSet.Update(entity);
            await SaveChanges();
        }

        public async Task<IEnumerable<TEntity>> Buscar(Expression<Func<TEntity, bool>> predicate)
        {
            return await _DbSet.Where(predicate).ToListAsync();
        }

        public async Task<TEntity> ObterPorId(Guid id)
        {
            return await _DbSet.FirstOrDefaultAsync(_ => _.Id == id);
        }

        public async Task<List<TEntity>> ObterTodos()
        {
            return await _DbSet.ToListAsync();
        }

        public async Task Remover(Guid id)
        {
            _DbSet.Remove(new TEntity { Id = id });
            await SaveChanges();
        }

        public async Task<int> SaveChanges()
        {
            return await _DbContext.SaveChangesAsync();
        }
    }
}
