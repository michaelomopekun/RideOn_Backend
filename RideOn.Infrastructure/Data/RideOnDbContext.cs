using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace RideOn.Infrastructure.Data;

public class RideOnDbContext : IdentityDbContext<IdentityUser>
{

    public RideOnDbContext(DbContextOptions<RideOnDbContext> options) : base(options)
    {
    }
    
    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        builder.HasDefaultSchema("public");

        // Add timestamp columns
        foreach (var entityType in builder.Model.GetEntityTypes())
        {
            if (entityType.ClrType.GetProperty("CreatedAt") != null)
            {
                builder.Entity(entityType.ClrType)
                    .Property("CreatedAt")
                    .HasColumnType("timestamp with time zone")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");
            }
            if (entityType.ClrType.GetProperty("UpdatedAt") != null)
            {
                builder.Entity(entityType.ClrType)
                    .Property("UpdatedAt")
                    .HasColumnType("timestamp with time zone")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");
            }
        }

    }
    
}
