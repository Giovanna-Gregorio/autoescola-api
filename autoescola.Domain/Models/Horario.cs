using System.Collections.Generic;

namespace autoescola.Domain.Models
{
    public class Horario : IModel<int>
    {
        public int Id { get; set; }
        public double Inicio { get; set; }
        public double Termino { get; set; }

        public virtual IList<Agenda> Agenda { get; set; }
    }
}
