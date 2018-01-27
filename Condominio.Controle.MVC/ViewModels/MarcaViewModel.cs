using System.ComponentModel.DataAnnotations;

namespace Condominio.Controle.MVC.ViewModels
{
    public class MarcaViewModel
    {
        [Key]        
        public int MarcaId { get; set; }  
             
        public string Descricao { get; set; }
    }
}