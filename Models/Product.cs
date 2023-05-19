using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ProjetoBasicoDesenvolvedorIOMVCCore.Models
{
    public class Product : Entity
    {
        [DisplayName("Fornecedor")]
        public Guid SupplierId { get; set; }
        [DisplayName("Fornecedor")]
        public Supplier Supplier { get; set; }
        [DisplayName("Nome")]
        [Required(ErrorMessage = "O campo Nome é obrigatório")]
        [StringLength(200, ErrorMessage = "O campo Nome deve conter de {2} até {1} caracteres", MinimumLength = 2)]
        public string Name { get; set; }
        [Required(ErrorMessage = "O campo Imagem é obrigatório")]
        [StringLength(200, ErrorMessage = "O campo Nome deve conter de {2} até {1} caracteres", MinimumLength = 0)]
        [DisplayName("Imagem")]
        public string Image { get; set; }
        [Required(ErrorMessage = "O campo Descrição é obrigatório")]
        [StringLength(1000, ErrorMessage = "O campo Nome deve conter de {2} até {1} caracteres", MinimumLength = 0)]
        [DisplayName("Descrição")]
        public string Description { get; set; }
        [Required(ErrorMessage = "O campo Valor é obrigatório")]
        [DisplayName("Valor")]
        public decimal Value { get; set; }
        [DisplayName("Data de Criação")]
        public DateTime CreatedDate { get; set; }
        [DisplayName("Ativo?")]
        public bool Active { get; set; }
    }
}
