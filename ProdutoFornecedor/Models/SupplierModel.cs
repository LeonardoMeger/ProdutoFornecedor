using System.ComponentModel.DataAnnotations;

namespace ProdutoFornecedor.Models
{
    public class SupplierModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Digite o nome do fornecedor")]
        public string Nome { get; set; }
        [Required(ErrorMessage = "Digite o telefone do fornecedor")]
        [Phone(ErrorMessage = "O celular informado não é valido!")]
        public string Telefone { get; set; }
    }
}
