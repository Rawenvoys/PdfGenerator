using PdfGenerator.Data.Domain.Models;
using PdfGenerator.Template.Domain.Models;

namespace PdfGenerator.Request.Domain.Models;
public class RequestModel(Guid id, TemplateModel templateModel, DataModel dataModel)
{
    public Guid Id { get; set; } = id;
    public TemplateModel Template { get; set; } = templateModel;
    public DataModel Data { get; set; } = dataModel;
}
