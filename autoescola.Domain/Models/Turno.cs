using System.Collections.Generic;

namespace autoescola.Domain.Models
{
    public class Turno : IModel<int>
    {
        public int Id { get; set; }
        public string Descricao { get; set; }

        public virtual IList<Instrutor> Instrutores { get; set; }
    }
}
