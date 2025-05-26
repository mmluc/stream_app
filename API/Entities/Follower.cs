namespace restApi.Entities
{
public class Follower
{
    public Guid Id { get; set; }

    public Guid FollowerId { get; set; }
    public User? Followers { get; set; }

    public Guid FollowedId { get; set; }
    public User? Followed { get; set; }

    public DateTime FollowedAt { get; set; }
}
}