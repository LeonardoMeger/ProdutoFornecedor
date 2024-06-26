using Microsoft.EntityFrameworkCore;
using ProdutoFornecedor.Data;
using ProdutoFornecedor.Models;
using ProdutoFornecedor.Repositories.Interfaces;

namespace ProdutoFornecedor.Repository
{
    public class ProductRepository : IProductRepository
    {
        private readonly ProductSupplierDbContext _productSupplierDbContext;

        public ProductRepository(ProductSupplierDbContext productSupplierDbContext)
        {
            _productSupplierDbContext = productSupplierDbContext;
        }

        public List<ProductModel> BuscarProdutos()
        {
            return _productSupplierDbContext.Produtos.ToList();
        }
        public ProductModel BuscarProdutoPorId(int id)
        {
            return _productSupplierDbContext.Produtos.FirstOrDefault(x => x.Id == id);   
        }

        public ProductModel AdicionarProduto(ProductModel produto)
        {
            produto.Data_Criacao = DateTime.Now;    
            _productSupplierDbContext.Produtos.Add(produto);
            _productSupplierDbContext.SaveChanges();

            return produto;
        }
        public ProductModel AtualizarProduto(ProductModel produto)
        {
            ProductModel prod = BuscarProdutoPorId(produto.Id);

            if (prod == null) throw new Exception("Houve um erro na atualização do produto");

            prod.Nome = produto.Nome;
            prod.Descricao = produto.Descricao; 
            prod.Preco = produto.Preco;

            _productSupplierDbContext.Produtos.Update(prod);
            _productSupplierDbContext.SaveChanges();

            return prod;
        }

        public bool ApagarProduto(int id)
        {
            ProductModel prod = BuscarProdutoPorId(id);

            if (prod == null) throw new Exception("Houve um erro ao deletar do produto");

            _productSupplierDbContext.Produtos.Remove(prod);
            _productSupplierDbContext.SaveChanges();

            return true;
        }

        public ProductSupplierModel AdicionarFornecedor(ProductModel produto, int FornecedorId)
        {
            var suppProd = new ProductSupplierModel
            {
                ProdutoId = produto.Id,
                FornecedorId = FornecedorId
            };

            var existingFornecedor = _productSupplierDbContext.Fornecedores.Find(FornecedorId);
            if (existingFornecedor == null)
            {
                throw new Exception("Fornecedor não encontrado.");
            }

            if (suppProd == null) throw new Exception("Houve um erro no vinculo do fornecedor ao produto");
            _productSupplierDbContext.ProdutoFornecedor.Add(suppProd);
            _productSupplierDbContext.SaveChanges();   
            return suppProd;
        }

        public bool ApagarProdutosFornecedor(int id)
        {
            ProductSupplierModel prodSuppl = BuscarProdutosFornecedorPorId(id);

            if (prodSuppl == null) throw new Exception("Houve um erro ao deletar do produto");

            _productSupplierDbContext.ProdutoFornecedor.Remove(prodSuppl);
            _productSupplierDbContext.SaveChanges();

            return true;
        }

        public ProductSupplierModel BuscarProdutosFornecedorPorId(int id)
        {
            return _productSupplierDbContext.ProdutoFornecedor.FirstOrDefault(x => x.ProdutoId == id);
        }

        List<ProductSupplierModel> IProductRepository.BuscarProdutosFornecedorPorId(int id)
        {
            throw new NotImplementedException();
        }
    }
}
