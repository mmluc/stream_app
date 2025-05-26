public class CreateVideoDto
{
    public string? Title { get; set; }
    public string? Description { get; set; }
    public string? UploaderId { get; set; }
    public List<Guid>? TagIds { get; set; }
}

public class VideoResponseDto
{
    public Guid Id { get; set; }
    public string? Title { get; set; }
    public string? Description { get; set; }
    public Guid UploaderId { get; set; }
    public DateTime UploadedAt { get; set; }
    public List<Guid>? TagNames { get; set; }
}
