namespace ChatApp.Domain.Entities;

public class MessageEntity
{
    public Guid Id { get; set; }
    public string Content { get; set; }
    public Guid SenderId { get; set; }
    public UserEntity Sender { get; set; }
    public Guid ReceiverId { get; set; }
    public UserEntity Receiver { get; set; }
    public DateTime SentAt { get; set; }
    public bool IsRead { get; set; }
}