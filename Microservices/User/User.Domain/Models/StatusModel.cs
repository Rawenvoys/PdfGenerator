using PdfGenerator.User.Domain.Enums;

namespace PdfGenerator.User.Domain.Models;
public class StatusModel
{
    public Guid Id { get; }
    public Status Status { get; }
    public DateTime EventDate { get; }
}
