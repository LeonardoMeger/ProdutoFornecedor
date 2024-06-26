using Microsoft.EntityFrameworkCore;
using ProdutoFornecedor.Data.Map;
using ProdutoFornecedor.Models;

namespace ProdutoFornecedor.Data
{
    public class ProductSupplierDbContext : DbContext
    {
        public ProductSupplierDbContext(DbContextOptions<ProductSupplierDbContext> opstion) : base(opstion)
        {

        }
        public DbSet<ProductModel> Produtos { get; set; }
        public DbSet<SupplierModel> Fornecedores { get; set; }
        public DbSet<ProductSupplierModel> ProdutoFornecedor { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ProductMap());
            modelBuilder.ApplyConfiguration(new SupplierMap());
            modelBuilder.ApplyConfiguration(new ProductSupplierMap());
            base.OnModelCreating(modelBuilder);
        }
    }
}
