using System.ComponentModel.DataAnnotations;

namespace Condominio.Controle.MVC.ViewModels
{
    public class VeiculoViewModel
    {
        [Key]
        public int VeiculoId { get; set; }

        [Required(ErrorMessage = "Digite a Placa do Veiculo")]
        [MaxLength(8, ErrorMessage = "Máximo {1} Caracteres")]
        public string Placa { get; set; }

        [Required(ErrorMessage = "Digite a Cor do Veiculo")]
        [MaxLength(10, ErrorMessage = "Máximo {1} Caracteres")]
        public string Cor { get; set; }

        [Required(ErrorMessage = "Selecione o Modelo do Veiculo")]
        public int ModeloId { get; set; }

        [Required(ErrorMessage = "Informe o Proprietario")]
        public int ProprietarioId { get; set; }

        public ProprietarioViewModel Proprietario { get; set; }
        public ModeloViewModel Modelo { get; set; }
    }
}