using ChatApp.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ChatApp.Infrastructure.EfMappings;

public class MessageEntityConfiguration:IEntityTypeConfiguration<MessageEntity>
{
    public void Configure(EntityTypeBuilder<MessageEntity> builder)
    {
        builder.ToTable("Messages");
        builder.HasKey(m => m.Id);
        builder.Property(m => m.Id).HasColumnName("message_id");
        builder.Property(m=>m.Content).HasColumnName("content");
        builder.Property(m=>m.SentAt).IsRequired().HasColumnType("datetime").HasDefaultValueSql("CURRENT_TIMESTAMP").HasColumnName("sent_at");
        builder.Property(m=>m.IsRead).IsRequired().HasDefaultValue(false).HasColumnName("is_read");
        builder.HasOne(m=>m.Sender).WithMany(u=>u.MessageSent).HasForeignKey(m=>m.SenderId);
        builder.HasOne(m=>m.Receiver).WithMany(u=>u.MessageReceived).HasForeignKey(m=>m.ReceiverId);
    }
}