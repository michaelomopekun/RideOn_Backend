using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RideOn.Domain.Entities;

namespace RideOn.Infrastructure.Data.Configurations;

public class RiderConfiguration : IEntityTypeConfiguration<Rider>
{
    public void Configure(EntityTypeBuilder<Rider> builder)
    {
        builder.ToTable("Riders");
        builder.Property(r => r.ProfilePictureUrl).HasMaxLength(500);
        builder.Property(r => r.Country).HasMaxLength(100);
        builder.Property(r => r.TotalTrips).IsRequired().HasDefaultValue(0);
        builder.Property(r => r.CreatedAt).IsRequired().HasDefaultValueSql("CURRENT_TIMESTAMP");
        builder.Property(r => r.UpdatedAt).IsRequired(false);
    }
}
