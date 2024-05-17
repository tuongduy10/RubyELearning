namespace Rel.Domain.Abstractions.Entities.Interfaces;

public abstract class GenericAuditSoftDeleteEntity<T> : GenericEntity<T>, IGenericAuditSoftDeleteEntity<T>
{
    public bool IsDeleted { get; set; } = false;
    public DateTime? DeletedDate { get; set; } = null;
    public string? DeletedBy { get; set; } = null;
}
