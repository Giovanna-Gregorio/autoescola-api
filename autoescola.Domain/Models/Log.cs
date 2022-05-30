using System;

namespace autoescola.Domain.Models
{
    public class Log : IModel<int>
    {
        public int Id { get; set; }
        public string Tipo { get; set; } //Login, exclusão, alteração
        public bool Status { get; set; } //true, false
        public DateTime Data { get; set; }
        public int? UsuarioId { get; set; }  
        public string Dados { get; set; }

        public virtual Usuario Usuario { get; set; }
    }
}
