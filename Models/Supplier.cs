using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ProjetoBasicoDesenvolvedorIOMVCCore.Models
{
    public class Supplier: Entity
    {
        [DisplayName("Nome")]
        [Required(ErrorMessage = "O campo Nome é obrigatório")]
        [StringLength(200, ErrorMessage = "O campo Nome deve conter de {2} até {1} caracteres", MinimumLength = 2)]
        public string Name { get; set; }
        [Required(ErrorMessage = "O campo Documento é obrigatório")]
        [StringLength(14, ErrorMessage = "O campo Nome deve conter de {2} até {1} caracteres", MinimumLength = 11)]
        [DisplayName("Documento")]
        public string Document { get; set; }
        [Required(ErrorMessage = "O campo Tipo de Fornecedor é obrigatório")]
        [DisplayName("Tipo de Fornecedor")]
        public SupplierType Type { get; set; }
        [DisplayName("Endereço")]
        public Address Address { get; set; }
        [DisplayName("Ativo?")]
        public bool Active { get; set; }


        public IEnumerable<Product> Products { get; set; }
    }

    public enum SupplierType { 
        PF,
        PJ
    }
}
