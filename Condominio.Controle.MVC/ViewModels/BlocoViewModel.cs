using System.ComponentModel.DataAnnotations;

namespace Condominio.Controle.MVC.ViewModels
{
    public class BlocoViewModel
    {
        [Key]        
        public int BlocoId { get; set; }

        [Required(ErrorMessage = "Digite a Descrição")]
        [MaxLength(1, ErrorMessage = "Digite somente a Letra Exemplo 'B'")]        
        public string Descricao { get; set; }
    }
}