using restApi.Entities;
public class Comment
{
    public Guid Id { get; set; }
    public string Message { get; set; } = string.Empty;
    public DateTime SentAt { get; set; }

    public Guid UserId { get; set; }
    public User? User { get; set; }

    public Guid StreamId { get; set; }
    public Stream? Stream { get; set; }
}
