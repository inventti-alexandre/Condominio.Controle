namespace Condominio.Controle.Domain.Entities
{
    public class Apartamento
    {
        public Apartamento()
        {
            Bloco = new Bloco();
        }
        public int ApartamentoId { get; set; }
        /// <summary>
        /// A Descrição deverá ser a junção do Bloco com o numero do apartamento
        /// </summary>
        public string Descricao { get; set; }
        public int BlocoId { get; set; }
        public int ProprietarioId { get; set; }
        /// <summary>
        /// Virtual para o Lazy Load Sobreescrever dados
        /// </summary>
        public virtual Proprietario Proprietario { get; set; }
        public virtual Bloco Bloco { get; set; }
    }
}
