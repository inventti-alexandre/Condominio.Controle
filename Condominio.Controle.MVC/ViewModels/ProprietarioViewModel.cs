using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Condominio.Controle.MVC.ViewModels
{
    public class ProprietarioViewModel
    {
        [Key]
        public int ProprietarioId { get; set; }

        [Required(ErrorMessage = "Digite o Nome")]
        [MaxLength(20,ErrorMessage = "Máximo {1} Carateres")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Digite o Sobre Nome")]
        [Display(Name = "Sobre Nome")]
        [MaxLength(50, ErrorMessage = "Máximo {1} Carateres")]
        public string SobreNome { get; set; }

        [MaxLength(20, ErrorMessage = "Máximo {1} Carateres")]
        public string Apelido { get; set; }

        [MaxLength(12, ErrorMessage = "Máximo {1} Carateres")]
        public string CPF { get; set; }

        public DateTime DataCadastro { get; set; }

        [Required(ErrorMessage = "Digite o Telefone")]
        [MaxLength(15, ErrorMessage = "Máximo {1} Carateres")]
        public string Telefone { get; set; }

        [Display(Name = "Número do Interfone")]
        [MaxLength(5, ErrorMessage = "Máximo {1} Carateres")]
        public string Numero_Interfone { get; set; }

        public virtual ICollection<ApartamentoViewModel> Apartamentos { get; set; }
        public virtual ICollection<VeiculoViewModel> Veiculos { get; set; }
    }
}