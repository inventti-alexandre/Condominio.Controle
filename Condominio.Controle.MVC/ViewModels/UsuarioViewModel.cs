using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Condominio.Controle.MVC.ViewModels
{
    public class UsuarioViewModel
    {
        [Key]
        public int UsuarioId { get; set; }

        [MaxLength(15, ErrorMessage = "Máximo {1} Caracteres")]
        [Required(ErrorMessage = "Digite o Nome do Usuario")]
        public string Nome { get; set; }

        [MaxLength(8, ErrorMessage = "Máximo {1} Caracteres")]
        [Required(ErrorMessage = "Digite a Senha do Usuario")]
        public string Senha { get; set; }

        [MaxLength(20, ErrorMessage = "Máximo {1} Caracteres")]
        [Required(ErrorMessage = "Digite o E-Mail do Usuario")]
        [DataType(DataType.EmailAddress, ErrorMessage = "Digite um E-Mail Válido")]
        public string Email { get; set; }

        public bool IsAuthenticated { get; set; }
    }
}