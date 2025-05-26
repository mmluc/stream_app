public class CreateNotificationDto
{
    public Guid UserId { get; set; }
    public string? Title { get; set; }
    public string? Message { get; set; }
    public string? Type { get; set; }
    public string? Link { get; set; }
}

public class NotificationResponseDto
{
    public Guid Id { get; set; }
    public string? Title { get; set; }
    public string? Message { get; set; }
    public bool IsRead { get; set; }
    public DateTime CreatedAt { get; set; }
}
