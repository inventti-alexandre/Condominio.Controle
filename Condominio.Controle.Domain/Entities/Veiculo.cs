namespace Condominio.Controle.Domain.Entities
{
    public class Veiculo
    {
        public int VeiculoId { get; set; }
        public string Placa { get; set; }        
        public string Cor { get; set; }
        public int ModeloId { get; set; }
        public int ProprietarioId { get; set; }
        public Proprietario Proprietario { get; set; }
        public Modelo Modelo { get; set; }
    }
}
