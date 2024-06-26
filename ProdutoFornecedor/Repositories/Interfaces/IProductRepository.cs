using ProdutoFornecedor.Models;

namespace ProdutoFornecedor.Repositories.Interfaces
{
    public interface IProductRepository
    {
        List<ProductModel> BuscarProdutos();
        ProductModel BuscarProdutoPorId(int id);
        ProductModel AdicionarProduto(ProductModel produto);
        ProductModel AtualizarProduto(ProductModel produto);
        bool ApagarProduto(int id);
        ProductSupplierModel AdicionarFornecedor(ProductModel produto, int FornecedorId);
        List<ProductSupplierModel> BuscarProdutosFornecedorPorId(int id);
        bool ApagarProdutosFornecedor(int id);
    }
}
