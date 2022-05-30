using System.Collections.Generic;

namespace autoescola.Domain.Models
{
    public class TipoHabilitacao : IModel<int>
    {
        public int Id { get; set; }
        public string Descricao { get; set; }

        public virtual IList<Matricula> Matriculas { get; set; }
    }
}
