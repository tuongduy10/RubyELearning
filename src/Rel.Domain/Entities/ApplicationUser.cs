namespace Rel.Domain.Entities;

public class ApplicationUser : GenericEntity<Guid>
{
    public string UserName { get; set; }
    public string Password { get; set; }
    public string Email { get; set; }
}
