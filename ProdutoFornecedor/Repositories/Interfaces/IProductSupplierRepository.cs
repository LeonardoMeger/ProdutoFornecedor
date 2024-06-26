using ProdutoFornecedor.Models;

namespace ProdutoFornecedor.Repositories.Interfaces
{
    public interface IProductSupplierRepository
    {
        List<ProductSupplierModel> BuscarProdutosFornecedor();
        ProductSupplierModel BuscarProdutosFornecedorPorId(int id);
        ProductSupplierModel AdicionarFornecedor(ProductSupplierModel produto, int id);
        ProductSupplierModel AtualizarProdutosFornecedor(ProductSupplierModel produto);
        bool ApagarProdutosFornecedor(int id);
        ProductSupplierModel AdicionarFornecedor(ProductModel produto, int FornecedorId);
        List<ProductSupplierModel> BuscarAll();
    }
}
