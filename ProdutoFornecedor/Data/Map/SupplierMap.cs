using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProdutoFornecedor.Models;

namespace ProdutoFornecedor.Data.Map
{
    public class SupplierMap : IEntityTypeConfiguration<SupplierModel>
    {
        public void Configure(EntityTypeBuilder<SupplierModel> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Nome).IsRequired().HasMaxLength(255);
            builder.Property(x => x.Telefone).IsRequired();
        }
    }
}
