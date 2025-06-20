using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using RideOn.Infrastructure.Data.Configurations;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using RideOn.Domain.Entities;

namespace RideOn.Infrastructure.Data;

public class RideOnDbContext(DbContextOptions<RideOnDbContext> options) : IdentityDbContext<IdentityUser>(options)
{
    public DbSet<Rider> Riders { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        builder.ApplyConfiguration(new RiderConfiguration());

        // builder.HasDefaultSchema("public");

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
