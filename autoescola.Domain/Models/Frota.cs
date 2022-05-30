namespace autoescola.Domain.Models
{
    public class Frota : IModel<int>
    {
        public int Id { get; set; }
        public int Ano { get; set; }
        public int MarcaId { get; set; }
        public string Modelo { get; set; }
        public string Cor { get; set; }
        public string Placa { get; set; }
        public string Observacao { get; set; }

        public virtual Marca Marca { get; set; }
    }
}
