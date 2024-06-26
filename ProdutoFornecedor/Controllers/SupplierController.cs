using Microsoft.AspNetCore.Mvc;
using ProdutoFornecedor.Models;
using ProdutoFornecedor.Repositories.Interfaces;
using ProdutoFornecedor.Repository;

namespace ProdutoFornecedor.Controllers
{
    public class SupplierController : Controller
    {
        private readonly ISupplierRepository _supplierRepository;
        public SupplierController(ISupplierRepository supplierRepository)
        {
            _supplierRepository = supplierRepository;
        }
        public IActionResult Index()
        {
            List<SupplierModel> supplier = _supplierRepository.BuscarFornecedores();
            return View(supplier);
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
            SupplierModel supplier = _supplierRepository.BuscarFornecedorePorId(id);
            return View(supplier);
        }
        public IActionResult Delete(int id)
        {
            SupplierModel supplier = _supplierRepository.BuscarFornecedorePorId(id);
            return View(supplier);
        }
        public IActionResult DeleteConfirmed(int id)
        {
            try
            {
                bool deleted = _supplierRepository.ApagarFornecedor(id);
                if (deleted)
                {
                    TempData["MensagemSucesso"] = "Fornecedor apagado com sucesso";
                }
                else
                {
                    TempData["MensagemErro"] = "Fornecedor não apagado, detalhe do erro";
                }
                return RedirectToAction("Index");
            }
            catch (Exception erro)
            {
                TempData["MensagemErro"] = $"Fornecedor não apagado, detalhe do erro: {erro.Message}";
                return RedirectToAction("Index");
            }
        }
        [HttpPost]
        public IActionResult Create(SupplierModel supplier)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _supplierRepository.AdicionarFornecedor(supplier);
                    TempData["MensagemSucesso"] = "Fornecedor cadastrado com sucesso";
                    return RedirectToAction("Index");
                }

                return View(supplier);
            }
            catch (Exception erro)
            {
                TempData["MensagemErro"] = $"Fornecedor não cadastrado, detalhe do erro: {erro.Message}";
                return RedirectToAction("Index");
            }

        }

        [HttpPost]
        public IActionResult Edit(SupplierModel supplier)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _supplierRepository.AtualizarFornecedor(supplier);
                    TempData["MensagemSucesso"] = "Fornecedor atualizado com sucesso";
                    return RedirectToAction("Index");
                }
                return View("Edit", supplier);
            }
            catch (Exception erro)
            {
                TempData["MensagemErro"] = $"Fornecedor não atualizar, detalhe do erro: {erro.Message}";
                throw;
            }
        }

    }
}
