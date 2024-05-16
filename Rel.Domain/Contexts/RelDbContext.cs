using Microsoft.EntityFrameworkCore;

namespace Rel.Domain.Contexts;

public class RelDbContext(DbContextOptions<RelDbContext> options) : DbContext(options)
{
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.HasDefaultSchema("dbo");
        base.OnModelCreating(modelBuilder);
    }
}
