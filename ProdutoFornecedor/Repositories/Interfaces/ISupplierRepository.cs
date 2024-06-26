using ProdutoFornecedor.Models;

namespace ProdutoFornecedor.Repositories.Interfaces
{
    public interface ISupplierRepository
    {
        List<SupplierModel> BuscarFornecedores();
        SupplierModel BuscarFornecedorePorId(int id);
        SupplierModel AdicionarFornecedor(SupplierModel fornecedor);
        SupplierModel AtualizarFornecedor(SupplierModel fornecedor);
        bool ApagarFornecedor(int id);
    }
}
