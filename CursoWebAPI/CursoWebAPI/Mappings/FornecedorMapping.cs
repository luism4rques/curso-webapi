using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using CursoWebAPI.Model;

namespace CursoWebAPI.Mappings
{
    public class FornecedorMapping : IEntityTypeConfiguration<Fornecedor>
    {
        public void Configure(EntityTypeBuilder<Fornecedor> builder)
        {
            builder.ToTable("Fornecedores", "CursoWebAPI");
            builder.HasKey(_ => _.FornecedorId);
            builder.HasMany(_ => _.Produtos).WithOne(_ => _.Fornecedor).HasForeignKey(_ => _.FornecedorId);
            builder.Property(_ => _.Nome).HasMaxLength(100).IsRequired();
            builder.Property(_ => _.Documento).HasMaxLength(14).IsRequired();
        }
    }
}