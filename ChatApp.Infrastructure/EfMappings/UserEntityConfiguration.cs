using ChatApp.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace ChatApp.Infrastructure.EfMappings;
public class UserEntityConfiguration:IEntityTypeConfiguration<UserEntity>
{
    public void Configure(EntityTypeBuilder<UserEntity> builder)
    {
        builder.ToTable("Users");
        builder.HasKey(u => u.Id);
        builder.Property(u => u.Id).HasColumnName("user_id");
        builder.Property(u => u.Name).HasColumnName("fullname").IsRequired();
        builder.Property(u => u.UserName).HasColumnName("username").IsRequired();
        builder.HasIndex(u => u.UserName).IsUnique();
        builder.Property(u => u.Email).HasColumnName("email").IsRequired();
        builder.HasIndex(u => u.Email).IsUnique();
        builder.Property(u=>u.Password).HasColumnName("password").IsRequired();
        builder.Property(u=>u.Bio).HasColumnName("bio");
        builder.Property(u=>u.ProfileImage).HasColumnName("profile_image");
        builder.Property(u => u.CreatedAt).HasColumnName("created_at").HasColumnType("datetime")
            .HasDefaultValueSql("CURRENT_TIMESTAMP");
        builder.Property(u=>u.UpdatedAt).HasColumnName("updated_at").HasColumnType("datetime").HasDefaultValueSql("CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP");
    }
}