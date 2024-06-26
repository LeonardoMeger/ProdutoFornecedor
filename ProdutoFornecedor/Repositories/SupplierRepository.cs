using ProdutoFornecedor.Data;
using ProdutoFornecedor.Models;
using ProdutoFornecedor.Repositories.Interfaces;

namespace ProdutoFornecedor.Repository
{
    public class SupplierRepository : ISupplierRepository
    {
        private readonly ProductSupplierDbContext _productSupplierDbContext;

        public SupplierRepository(ProductSupplierDbContext productSupplierDbContext)
        {
            _productSupplierDbContext = productSupplierDbContext;
        }

        public List<SupplierModel> BuscarFornecedores()
        {
            return _productSupplierDbContext.Fornecedores.ToList();
        }

        public SupplierModel BuscarFornecedorePorId(int id)
        {
            return _productSupplierDbContext.Fornecedores.FirstOrDefault(x => x.Id == id);
        }

        public SupplierModel AdicionarFornecedor(SupplierModel fornecedor)
        {
            _productSupplierDbContext.Fornecedores.Add(fornecedor);
            _productSupplierDbContext.SaveChanges();

            return fornecedor;
        }

        public SupplierModel AtualizarFornecedor(SupplierModel fornecedor)
        {
            SupplierModel supplier = BuscarFornecedorePorId(fornecedor.Id);

            if (supplier == null) throw new Exception("Houve um erro na atualização do fornecedor");

            supplier.Nome = fornecedor.Nome;
            supplier.Telefone = fornecedor.Telefone;

            _productSupplierDbContext.Fornecedores.Update(supplier);
            _productSupplierDbContext.SaveChanges();

            return supplier;
        }

        public bool ApagarFornecedor(int id)
        {
            SupplierModel supplier = BuscarFornecedorePorId(id);

            if (supplier == null) throw new Exception("Houve um erro ao deletar o fornecedor");

            _productSupplierDbContext.Fornecedores.Remove(supplier);
            _productSupplierDbContext.SaveChanges();

            return true;
        }
    }
}
