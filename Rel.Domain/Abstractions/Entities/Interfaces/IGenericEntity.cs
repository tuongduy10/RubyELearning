namespace Rel.Domain.Abstractions.Entities.Interfaces;

public interface IGenericEntity<T> : IAuditCreate
{
    T Id { get; set; }
}
