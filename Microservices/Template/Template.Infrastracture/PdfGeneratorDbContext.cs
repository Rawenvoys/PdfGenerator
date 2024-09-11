using Dapper.Lib.Models.DbContext;
using Microsoft.Extensions.Configuration;

namespace PdfGenerator.Template.Infrastracture;
public class PdfGeneratorDbContext(IConfiguration configuration) : ADbContext(new PdfGeneratorConnectionString(configuration))
{
}
