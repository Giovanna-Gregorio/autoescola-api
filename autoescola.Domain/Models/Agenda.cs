namespace autoescola.Domain.Models
{
    public class Agenda : IModel<int>
    {
        public int Id { get; set; }
        public int MatriculaId { get; set; }
        public int InstrutorId { get; set; }
        public int HorarioId { get; set; }

        public virtual Matricula Matricula { get; set; }
        public virtual Instrutor Instrutor { get; set; }
        public virtual Horario Horario { get; set; }
    }
}
