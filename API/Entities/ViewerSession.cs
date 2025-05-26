namespace restApi.Entities
{

    public class ViewerSession
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public Guid UserId {get; set;}
    public Guid StreamId {get; set;}
    public DateTime JoinedAt {get; set;} = DateTime.UtcNow;
    public DateTime LeftAt {get; set;}


}
}