namespace Rel.Domain.Abstractions.Exceptions;

public class NotFoundException : DomainException
{
    public NotFoundException(string message) : base("Not Found", message)
    {
    }
}
