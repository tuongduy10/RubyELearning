namespace Rel.Domain.Abstractions.Entities.Interfaces;

public abstract class GenericEntity<T> : IGenericEntity<T>
{
    public T Id { get; set; }
    public DateTime CreatedDate { get; set; } = DateTime.Now;
    public required string CreatedBy { get; set; }
}
