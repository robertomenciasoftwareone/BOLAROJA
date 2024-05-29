using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using BolaRoja.Services.Marketing.API.Model;

namespace BolaRoja.Services.Marketing.API.Infrastructure.EntityConfigurations
{
    class UserLocationRuleEntityTypeConfiguration
       : IEntityTypeConfiguration<UserLocationRule>
    {
        public void Configure(EntityTypeBuilder<UserLocationRule> builder)
        {
            builder.Property(r => r.LocationId)
            .HasColumnName("LocationId")
            .IsRequired();
        }
    }
}
