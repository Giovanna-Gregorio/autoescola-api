using System.Collections.Generic;

namespace autoescola.Domain.Models
{
    public class Endereco : IModel<int>
    {
        public int Id { get; set; }
        public string Logradouro { get; set; }
        public string Bairro { get; set; }
        public string CEP { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }

        public virtual IList<Pessoa> Pessoas { get; set; }
    }
}
