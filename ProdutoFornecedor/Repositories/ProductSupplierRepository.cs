using Microsoft.EntityFrameworkCore;
using ProdutoFornecedor.Data;
using ProdutoFornecedor.Models;
using ProdutoFornecedor.Repositories.Interfaces;

namespace ProdutoFornecedor.Repositories
{
    public class ProductSupplierRepository : IProductSupplierRepository
    {
        private readonly ProductSupplierDbContext _productSupplierDbContext;

        public ProductSupplierRepository(ProductSupplierDbContext productSupplierDbContext)
        {
            _productSupplierDbContext = productSupplierDbContext;
        }
        public List<ProductSupplierModel> BuscarProdutosFornecedor()
        {
            return _productSupplierDbContext.ProdutoFornecedor.ToList();
        }
        public ProductSupplierModel BuscarProdutosFornecedorPorId(int id)
        {
            return _productSupplierDbContext.ProdutoFornecedor.FirstOrDefault(x => x.Id == id);
        }
        public ProductSupplierModel AdicionarProdutosFornecedor(ProductSupplierModel produtofornecedor)
        {
            _productSupplierDbContext.ProdutoFornecedor.Add(produtofornecedor);
            _productSupplierDbContext.SaveChanges();

            return produtofornecedor;
        }
        public ProductSupplierModel AtualizarProdutosFornecedor(ProductSupplierModel produto)
        {
            throw new NotImplementedException();
        }

        public bool ApagarProdutosFornecedor(int id)
        {
            ProductSupplierModel prodSuppl = BuscarProdutosFornecedorPorId(id);

            if (prodSuppl == null) throw new Exception("Houve um erro ao deletar do produto");

            _productSupplierDbContext.ProdutoFornecedor.Remove(prodSuppl);
            _productSupplierDbContext.SaveChanges();

            return true;
        }
        public ProductSupplierModel AdicionarFornecedor(ProductModel produto, int FornecedorId)
        {
            throw new NotImplementedException();
        }

        public ProductSupplierModel AdicionarFornecedor(ProductSupplierModel produto, int id)
        {
            throw new NotImplementedException();
        }

        public List<ProductSupplierModel> BuscarAll()
        {
            return _productSupplierDbContext.ProdutoFornecedor
                .Include(ps => ps.Produto)
                .Include(ps => ps.Fornecedor)
                .ToList();

        }
    }
}
