using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Condominio.Controle.MVC.ViewModels
{

    public class ApartamentoViewModel
    {
        public ApartamentoViewModel()
        {
            Bloco = new BlocoViewModel();
        }
        [Key]
        public int ApartamentoId { get; set; }
        /// <summary>
        /// A Descrição deverá ser a junção do Bloco com o numero do apartamento
        /// </summary>
        [Required(ErrorMessage = "Por favor Selecione o numero do Apartamento")]
        [MaxLength(4, ErrorMessage = "Máximo {1} Caracteres")]
        public string Descricao { get { return Bloco.Descricao + "-" + AptoNumero; } }

        public string AptoNumero { get; set; }

        [Required(ErrorMessage = "Selecione um Bloco")]
        public int BlocoId { get; set; }

        [Required(ErrorMessage = "Selecione o Proprietario")]
        public int ProprietarioId { get; set; }

        public virtual ProprietarioViewModel Proprietario { get; set; }

        public virtual BlocoViewModel Bloco { get; set; }
    }
}