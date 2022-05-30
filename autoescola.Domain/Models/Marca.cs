using System.Collections.Generic;

namespace autoescola.Domain.Models
{
    public class Marca : IModel<int>
    {
        public int Id { get; set; }
        public string Descricao { get; set; }

        public virtual IList<Frota> Frotas { get; set; }
    }
}
