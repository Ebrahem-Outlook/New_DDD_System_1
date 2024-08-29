using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using New_DDD_System.Domain.Users;

namespace New_DDD_System.Infrastructure.Configurations;

public sealed class UserConfiguration : IEntityTypeConfiguration<User>
{
    public void Configure(EntityTypeBuilder<User> builder)
    {
        builder.HasKey(user => user.Id);

        builder.Property(user => user.FristName)
               .HasColumnName(nameof(User.FristName))
               .HasMaxLength(50)
               .IsRequired();

        builder.Property(user => user.LastName)
               .HasColumnName(nameof(User.LastName))
               .HasMaxLength(50)
               .IsRequired();

        builder.Property(user => user.Phone)
               .HasColumnName(nameof(User.Phone))
               .HasMaxLength(20)
               .IsRequired();

        builder.Property(user => user.Email)
               .HasColumnName(nameof(User.Email))
               .HasMaxLength(100)
               .IsRequired();

        builder.HasIndex(user => user.Email).IsUnique();
    }
}
