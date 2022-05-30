using System.Collections.Generic;

namespace autoescola.Domain.Models
{
    public class Aluno : IModel<int>
    {
        public int Id { get; set; }
        public int PessoaId { get; set; }
        public string RG { get; set; }
        public string Profissao { get; set; }
        public string NomeMae { get; set; }
        public string NomePai { get; set; }

        public virtual Pessoa Pessoa { get; set; }  
        public virtual IList<Matricula> Matriculas { get; set; }
    }
}
