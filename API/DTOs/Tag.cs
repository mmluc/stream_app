public class CreateTagDto
{
    public string? Name { get; set; }
    public string? Slug { get; set; }
}

public class TagResponseDto
{
    public Guid Id { get; set; }
    public string? Name { get; set; }
    public string? Slug { get; set; }
}
