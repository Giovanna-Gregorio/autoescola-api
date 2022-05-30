using System.Collections.Generic;

namespace autoescola.Domain.Models
{
    public class Usuario : IModel<int>
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public int? PessoaId { get; set; }
        public bool Ativo { get; set; }
        public int Tentativas { get; set; }

        public virtual Pessoa Pessoa { get; set; }
        public virtual IList<Log> Logs { get; set; }
    } 
}