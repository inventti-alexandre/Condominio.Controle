using System.ComponentModel.DataAnnotations;

namespace Condominio.Controle.MVC.ViewModels
{
    public class ModeloViewModel
    {
        [Key]
        public int ModeloId { get; set; }
        public int MarcaId { get; set; }
        public MarcaViewModel Marca { get; set; }
        public string Descricao { get; set; }
    }
}