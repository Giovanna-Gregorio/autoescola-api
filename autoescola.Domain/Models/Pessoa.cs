using System;
using System.Collections.Generic;

namespace autoescola.Domain.Models
{
    public class Pessoa : IModel<int>
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string CPF { get; set; }
        public char Sexo { get; set; }
        public DateTime Nascimento { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }

        public int EnderecoId { get; set; }
        public string NumeroEndereco { get; set; }

        public virtual Endereco Endereco { get; set; }

        public virtual IList<Usuario> Usuarios { get; set; }
        public virtual IList<Aluno> Alunos { get; set; }
        public virtual IList<Instrutor> Instrutores { get; set; }  
    }
}
