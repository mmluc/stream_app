public class CreateSubscriptionDto
{
    public Guid SubscriberId { get; set; }
    public Guid CreatorId { get; set; }
}

public class SubscriptionResponseDto
{
    public Guid Id { get; set; }
    public Guid SubscriberId { get; set; }
    public Guid CreatorId { get; set; }
    public DateTime SubscribedAt { get; set; }
}
