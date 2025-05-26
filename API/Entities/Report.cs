namespace restApi.Entities
{
    public enum ReportedItemType
{
    Comment,
    Post,
    User,
    Message,
    Other
}
public class Report
{
    public Guid Id { get; set; }                
    public Guid ReporterUserId { get; set; }   
    public Guid ReportedItemId { get; set; }     
    public ReportedItemType Type { get; set; }   
    public string? Reason { get; set; }           
    public DateTime CreatedAt { get; set; }       
    public bool IsResolved { get; set; } = false;  
    public Guid ResolvedByUserId { get; set; }
    public DateTime? ResolvedAt { get; set; }    
    public string? ResolutionNotes { get; set; } 
}
}