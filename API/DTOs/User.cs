public class CreateUserDto
{
    public string? Username { get; set; }
    public string? Email { get; set; }
    public string? DisplayName { get; set; }
}

public class UserResponseDto
{
    public Guid Id { get; set; }
    public string? Username { get; set; }
    public string? DisplayName { get; set; }
    public DateTime RegisteredAt { get; set; }
}
