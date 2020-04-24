using CursoWebAPI.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CursoWebAPI.Mappings
{
    public class ProdutoMapping : IEntityTypeConfiguration<Produto>
    {
        public void Configure(EntityTypeBuilder<Produto> builder)
        {
            builder.ToTable("Produtos", "CursoWebAPI");
            builder.HasKey(_ => _.ProdutoId);
            builder.HasOne(_ => _.Fornecedor).WithMany(_ => _.Produtos).HasForeignKey(_ => _.FornecedorId);
            builder.Property(_ => _.Nome).HasMaxLength(50).IsRequired();
            builder.Property(_ => _.Descricao).HasMaxLength(100).IsRequired();
        }
    }
}