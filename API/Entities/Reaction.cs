namespace restApi.Entities
{
    public enum ReactionType {Like, Dislike}

    public class Reaction
{
     public Guid Id { get; set; } = Guid.NewGuid();
    public Guid UserId {get; set;}
    public Guid TargetId {get; set;}
    public ReactionType Type {get; set;}
  
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
 

    

}
}