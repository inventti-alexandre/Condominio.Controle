using System;
using System.Collections.Generic;

namespace Condominio.Controle.Domain.Entities
{
    public class Proprietario
    {
        public int ProprietarioId { get; set; }
        public string Nome { get; set; }
        public string SobreNome { get; set; }
        public string Apelido { get; set; }
        public string CPF { get; set; }
        public DateTime DataCadastro { get; set; }
        public string Telefone { get; set; }
        public string Numero_Interfone { get; set; }
        public virtual ICollection<Apartamento> Apartamentos { get; set; }
        public virtual ICollection<Veiculo> Veiculos { get; set; }
    }
}
