using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace ProdutoFornecedor.Models
{
    public class ProductModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Digite o nome do produto")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Digite a descrição do produto")]
        public string Descricao { get; set; }

        [Required(ErrorMessage = "Digite o preço do produto")]
        [Range(0.01, double.MaxValue, ErrorMessage = "O preço precisa ser um número positivo")]
        public decimal Preco { get; set; }

        public DateTime Data_Criacao { get; set; }
    }
}
