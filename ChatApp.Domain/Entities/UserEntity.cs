namespace ChatApp.Domain.Entities;

public class UserEntity
{
    public Guid Id { get; set; }
    
    public string Name { get; set; }
    
    public string Email { get; set; }
    
    public string Password { get; set; }
    
    public string UserName { get; set; }
    
    public string Bio { get; set; }
    
    public string ProfileImage { get; set; }
    
    public ICollection<MessageEntity> MessageSent { get; set; }
    public ICollection<MessageEntity> MessageReceived { get; set; }
    
    public DateTime CreatedAt { get; set; }
    
    public DateTime UpdatedAt { get; set; }
}