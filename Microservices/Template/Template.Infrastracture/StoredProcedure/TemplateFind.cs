using Dapper.Lib.Models.StoredProcedure;

namespace PdfGenerator.Template.Infrastracture.StoredProcedure;
public class TemplateFind(string templateName) : AStoredProcedure(ConfigureDictionary(templateName))
{
    public override string Name => "dbo.TemplateFind";
    private static Dictionary<string, object> ConfigureDictionary(string templateName) => new()
        {
            { "@templateName", templateName }
        };

}
