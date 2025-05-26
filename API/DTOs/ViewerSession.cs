public class CreateViewerSessionDto
{
    public Guid UserId { get; set; }
    public Guid VideoId { get; set; }
    public DateTime StartedAt { get; set; }
}

public class ViewerSessionResponseDto
{
    public Guid Id { get; set; }
    public Guid UserId { get; set; }
    public Guid VideoId { get; set; }
    public DateTime StartedAt { get; set; }
    public DateTime? EndedAt { get; set; }
}
