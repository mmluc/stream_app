public class CreateReportDto
{
    public Guid ReporterUserId { get; set; }
    public Guid ReportedItemId { get; set; }
    public string? ReportedItemType { get; set; }
    public string? Reason { get; set; }
}

public class ReportResponseDto
{
    public Guid Id { get; set; }
    public string? Reason { get; set; }
    public string? ReportedItemType { get; set; }
    public bool IsResolved { get; set; }
    public DateTime CreatedAt { get; set; }
}
