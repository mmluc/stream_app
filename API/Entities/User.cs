namespace restApi.Entities
{

    public class User
{
    public Guid Id { get; set; }
    public string Username { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public string PasswordHash { get; set; } = string.Empty;
    public DateTime CreatedAt { get; set; }

    public ICollection<Stream> Streams { get; set; } = new List<Stream>();
     public ICollection<Comment> Comments { get; set; } = new List<Comment>();

}
}