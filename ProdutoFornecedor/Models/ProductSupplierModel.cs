namespace ProdutoFornecedor.Models
{
    public class ProductSupplierModel
    {
        public int Id { get; set; }

        public int ProdutoId { get; set; }
        public int FornecedorId { get; set; }
        public virtual ProductModel? Produto { get; set; }
        public virtual SupplierModel Fornecedor { get; set; }
    }
}
