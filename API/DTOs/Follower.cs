public class CreateFollowerDto
{
    public Guid FollowerId { get; set; }
    public Guid FolloweeId { get; set; }
}

public class FollowerResponseDto
{
    public Guid Id { get; set; }
    public Guid FollowerId { get; set; }
    public Guid FolloweeId { get; set; }
    public DateTime FollowedAt { get; set; }
}
