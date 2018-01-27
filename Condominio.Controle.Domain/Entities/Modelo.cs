namespace Condominio.Controle.Domain.Entities
{
    public class Modelo
    {        
        public int ModeloId { get; set; }
        public int MarcaId { get; set; }
        public Marca Marca { get; set; }
        public string Descricao { get; set; }
    }
}
