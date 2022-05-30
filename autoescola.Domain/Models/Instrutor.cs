using System.Collections.Generic;

namespace autoescola.Domain.Models
{
    public class Instrutor : IModel<int>
    {
        public int Id { get; set; }
        public int TurnoId { get; set; }
        public int PessoaId { get; set; }

        public virtual Turno Turno { get; set; }
        public virtual Pessoa Pessoa { get; set; }

        public virtual IList<Agenda> Agenda { get; set; }
    }
}
