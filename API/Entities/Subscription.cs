namespace restApi.Entities
{

    public class Subscription
{
    public Guid Id { get; set; }
    public Guid FollowerId {get; set;}
    public Guid FolloweId {get; set;}
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
   

    

}
}