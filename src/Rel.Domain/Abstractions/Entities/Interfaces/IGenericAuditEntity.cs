namespace Rel.Domain.Abstractions.Entities.Interfaces;

public interface IGenericAuditEntity<T> : IGenericEntity<T>, IAuditable
{
}
