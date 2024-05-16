namespace Rel.Domain.Abstractions.Entities.Interfaces;

public interface IAuditSoftDelete
{
    public bool IsDeleted { get; set; }
    public DateTime? DeletedDate { get; set; }
    public string? DeletedBy { get; set; }
}

