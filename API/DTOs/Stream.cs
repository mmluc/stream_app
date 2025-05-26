public class CreateStreamEventDto
{
    public string? EventType { get; set; }    
    public Guid SourceId { get; set; }           
    public string? SourceType { get; set; }        
    public string? PayloadJson { get; set; }       
}
public class StreamEventResponseDto
{
    public Guid Id { get; set; }                     public string? EventType { get; set; }
    public Guid SourceId { get; set; }
    public string? SourceType { get; set; }
    public string? PayloadJson { get; set; }
    public DateTime Timestamp { get; set; }
}
