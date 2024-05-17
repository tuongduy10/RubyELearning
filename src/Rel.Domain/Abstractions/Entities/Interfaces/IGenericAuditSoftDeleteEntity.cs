namespace Rel.Domain.Abstractions.Entities.Interfaces;

public interface IGenericAuditSoftDeleteEntity<T> : IGenericEntity<T>, IAuditSoftDelete
{
}
