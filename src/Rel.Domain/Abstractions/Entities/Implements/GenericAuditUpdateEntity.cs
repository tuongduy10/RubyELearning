namespace Rel.Domain.Abstractions.Entities.Interfaces;

public abstract class GenericAuditUpdateEntity<T> : GenericEntity<T>, IGenericAuditUpdateEntity<T>
{
    public DateTime? UpdatedDate { get; set; } = null;
    public string? UpdatedBy { get; set; } = null;
}
