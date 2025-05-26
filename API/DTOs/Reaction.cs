public class CreateReactionDto
{
    public Guid UserId { get; set; }
    public Guid TargetId { get; set; }     // Could be a comment, post, etc.
    public string? TargetType { get; set; }   // e.g., "Comment", "Video"
    public string? ReactionType { get; set; } // e.g., "like", "dislike"
}

public class ReactionResponseDto
{
    public Guid Id { get; set; }
    public Guid UserId { get; set; }
    public Guid TargetId { get; set; }
    public string? ReactionType { get; set; }
    public DateTime CreatedAt { get; set; }
}
