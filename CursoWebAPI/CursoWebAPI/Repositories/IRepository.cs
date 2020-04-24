using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using CursoWebAPI.Models;
using System.Linq.Expressions;

namespace CursoWebAPI.Repositories
{
    public interface IRepository<TEntity> where TEntity : Entity
    {
        Task Adicionar(TEntity entity);

        Task<TEntity> ObterPorId(Guid id);

        Task<List<TEntity>> ObterTodos();

        Task Atualizar(TEntity entity);

        Task Remover(Guid id);

        Task<IEnumerable<TEntity>> Buscar(Expression<Func<TEntity, bool>> predicate);

        Task<int> SaveChanges();
    }
}