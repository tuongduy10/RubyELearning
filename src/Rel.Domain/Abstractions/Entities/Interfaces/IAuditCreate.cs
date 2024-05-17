namespace Rel.Domain.Abstractions.Entities.Interfaces;

public interface IAuditCreate
{
    public DateTime CreatedDate { get; set; }
    public string CreatedBy { get; set; }
}

