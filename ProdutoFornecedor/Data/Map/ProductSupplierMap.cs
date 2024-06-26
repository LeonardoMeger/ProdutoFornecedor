using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProdutoFornecedor.Models;

namespace ProdutoFornecedor.Data.Map
{
    public class ProductSupplierMap : IEntityTypeConfiguration<ProductSupplierModel>
    {
        public void Configure(EntityTypeBuilder<ProductSupplierModel> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.ProdutoId);
            builder.Property(x => x.FornecedorId);

            builder.HasOne(x => x.Produto);
            builder.HasOne(x => x.Fornecedor);
        }
    }
}
