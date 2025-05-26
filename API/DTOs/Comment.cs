public class CreateCommentDto
{
    public Guid UserId { get; set; }
    public Guid VideoId { get; set; }
    public string? Content { get; set; }
}

public class CommentResponseDto
{
    public Guid Id { get; set; }
    public string? Content { get; set; }
    public Guid UserId { get; set; }
    public DateTime CreatedAt { get; set; }
}
