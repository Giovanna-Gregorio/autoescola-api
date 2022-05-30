namespace autoescola.Domain.Models
{
    public interface IModel<T>
    {
        T Id { get; set; }
    }
}
