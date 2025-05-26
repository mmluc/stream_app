namespace restApi.Entities
{

    public class Video
{
    public Guid Id { get; set; }
    public Guid UserId {get; set;}
    public Guid StreamId {get; set;}
    public string Title { get; set; } = string.Empty;
    public string Url { get; set; } = string.Empty;
    public string ThumbnailUrl { get; set; } = string.Empty;
    public DateTime CreatedAt { get; set; }
    public TimeSpan Duration {get; set;}

    

}
}