using Microsoft.AspNetCore.Mvc;
using ProdutoFornecedor.Models;
using ProdutoFornecedor.Repositories.Interfaces;
using ProdutoFornecedor.Repository;

namespace ProdutoFornecedor.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductRepository _productRepository;
        public ProductController(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }
        public IActionResult Index()
        {
            List<ProductModel> produtcs = _productRepository.BuscarProdutos();
            return View(produtcs);
        }
        public IActionResult Details()
        {
            return View();
        }
        public IActionResult Create()
        {
            return View();
        }
        public IActionResult Edit(int id)
        {
            ProductModel product = _productRepository.BuscarProdutoPorId(id);
            return View(product);
        }
        public IActionResult Delete(int id)
        {
            ProductModel product = _productRepository.BuscarProdutoPorId(id);
            return View(product);
        }
        public IActionResult DeleteConfirmed(int id)
        {
            try
            {
                bool deleted = _productRepository.ApagarProduto(id);
                if (deleted)
                {
                    TempData["MensagemSucesso"] = "Produto apagado com sucesso";
                }
                else
                {
                    TempData["MensagemErro"] = "Produto não apagado, detalhe do erro";
                }
                return RedirectToAction("Index");
            }
            catch (Exception erro)
            {
                TempData["MensagemErro"] = $"Produto não apagado, detalhe do erro: {erro.Message}";
                return RedirectToAction("Index");
            }
        }

        public IActionResult Addsupplier(int id)
        {
            ProductModel product = _productRepository.BuscarProdutoPorId(id);
            return View(product);
        }

        [HttpPost]
        public IActionResult Create(ProductModel product)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _productRepository.AdicionarProduto(product);
                    TempData["MensagemSucesso"] = "Produto Cadastrado com sucesso";
                    return RedirectToAction("Index");
                }

                return View(product);
            }
            catch (Exception erro)
            {
                TempData["MensagemErro"] = $"Produto não cadastrado, detalhe do erro: {erro.Message}";
                return RedirectToAction("Index");
            }

        }

        [HttpPost]
        public IActionResult Edit(ProductModel product)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _productRepository.AtualizarProduto(product);
                    TempData["MensagemSucesso"] = "Produto atualizado com sucesso";
                    return RedirectToAction("Index");
                }
                return View("Edit", product);
            }
            catch (Exception erro)
            {
                TempData["MensagemErro"] = $"Produto não atualizar, detalhe do erro: {erro.Message}";
                throw;
            }
        }
        [HttpPost]
        public IActionResult Addsupplier(ProductModel productSupplier, int idSupplier)
        {
            try
            {

                    _productRepository.AdicionarFornecedor(productSupplier, idSupplier);
                TempData["MensagemSucesso"] = "Fornecedor vinculado com sucesso";
                return RedirectToAction("Index");

            }
            catch (Exception erro)
            {
                TempData["MensagemErro"] = $"Fornecedor não vinculado, detalhe do erro: {erro.Message}";
                return RedirectToAction("Index");
            }
        }
        public IActionResult DeleteSupplier(int id)
        {
            ProductModel product = _productRepository.BuscarProdutoPorId(id);
            return View(product);
        }
        public IActionResult DeleteSupplierConfirmed(int id)
        {
            try
            {
                bool deleted = _productRepository.ApagarProdutosFornecedor(id);
                if (deleted)
                {
                    TempData["MensagemSucesso"] = "Vinculo apagado com sucesso";
                }
                else
                {
                    TempData["MensagemErro"] = "Vinculo não apagado, detalhe do erro";
                }
                return RedirectToAction("Index");
            }
            catch (Exception erro)
            {
                TempData["MensagemErro"] = $"Vinculo não apagado, detalhe do erro: {erro.Message}";
                return RedirectToAction("Index");
            }
        }
    }
}
