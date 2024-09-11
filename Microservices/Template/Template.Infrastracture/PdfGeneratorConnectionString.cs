using Dapper.Lib.Models.ConnectionString;
using Microsoft.Extensions.Configuration;

namespace PdfGenerator.Template.Infrastracture;
internal class PdfGeneratorConnectionString(IConfiguration configuration) : AConnectionString(configuration)
{
    public override string Key => "PdfGeneratorDb";
}
