namespace Rel.Domain.Abstractions.Entities.Interfaces;

public interface IAuditUpdate
{
    public DateTime? UpdatedDate { get; set; }
    public string? UpdatedBy { get; set; }
}

