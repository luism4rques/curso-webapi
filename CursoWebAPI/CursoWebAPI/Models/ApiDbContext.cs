using CursoWebAPI.Mappings;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using CursoWebAPI.Models;

namespace CursoWebAPI.Models
{
    public class ApiDbContext : DbContext
    {
        public ApiDbContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration<Fornecedor>(new FornecedorMapping());
            modelBuilder.ApplyConfiguration<Produto>(new ProdutoMapping());

            foreach (var model in modelBuilder.Model.GetEntityTypes().SelectMany(_ => _.GetForeignKeys()))
                model.DeleteBehavior = DeleteBehavior.ClientSetNull;

            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Fornecedor> Fornecedores { get; set; }

        public DbSet<Produto> Produtos { get; set; }
    }
}