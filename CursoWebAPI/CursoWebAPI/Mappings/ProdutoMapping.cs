using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using CursoWebAPI.Models;

namespace CursoWebAPI.Mappings
{
    public class ProdutoMapping : IEntityTypeConfiguration<Produto>
    {
        public void Configure(EntityTypeBuilder<Produto> builder)
        {
            builder.ToTable("Produtos");
            builder.HasKey(_ => _.Id);
            builder.HasOne(_ => _.Fornecedor).WithMany(_ => _.Produtos).HasForeignKey(_ => _.FornecedorId);
            builder.Property(_ => _.Nome).HasMaxLength(50).IsRequired();
            builder.Property(_ => _.Descricao).HasMaxLength(100).IsRequired();
        }
    }
}