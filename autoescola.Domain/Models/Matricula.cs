using System.Collections.Generic;

namespace autoescola.Domain.Models
{
    public class Matricula : IModel<int>
    {
        public int Id { get; set; }
        public int AlunoId { get; set; }
        public int TipoHabilitacaoId { get; set; }

        public virtual Aluno Aluno { get; set; }
        public virtual TipoHabilitacao TipoHabilitacao { get; set; }

        public virtual IList<Agenda> Agenda { get; set; }
    }
}
