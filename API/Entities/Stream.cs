using restApi.Entities;

public class Stream 
{
    public Guid Id { get; set; }
    public string Title { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public string StreamUrl { get; set; } = string.Empty;
    public DateTime StartTime { get; set; }
    public bool IsLive { get; set; }

    public Guid UserId { get; set; }
    public User? User { get; set; }
}