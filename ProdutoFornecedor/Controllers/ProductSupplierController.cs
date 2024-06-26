using Microsoft.AspNetCore.Mvc;
using ProdutoFornecedor.Models;
using ProdutoFornecedor.Repositories.Interfaces;
using ProdutoFornecedor.Repository;

namespace ProdutoFornecedor.Controllers
{
    public class ProductSupplierController : Controller
    {
        private readonly IProductSupplierRepository _productSupplierRepository;
        public ProductSupplierController(IProductSupplierRepository productSupplierRepository)
        {
            _productSupplierRepository = productSupplierRepository;
        }
        public IActionResult Index()
        {
            List<ProductSupplierModel> productsSuppliers = _productSupplierRepository.BuscarAll();
            return View(productsSuppliers);
        }
    }
}
