namespace PdfGenerator.Template.Infrastracture.Dtos ;
internal class TemplateDto
{
    //ToDo: Czy pola bazodanowe powinny byc internal? czy Dapper sobie poradzi
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string FileStoragePath { get; set; }
    //public Guid UserId { get; set; }
}
