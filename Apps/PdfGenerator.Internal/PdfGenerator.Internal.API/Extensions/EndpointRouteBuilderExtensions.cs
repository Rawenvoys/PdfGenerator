namespace PdfGenerator.Internal.API.Extensions;

public static class EndpointRouteBuilderExtensions
{
    public static void AddRoutes(this IEndpointRouteBuilder endpointRouteBuilder)
    {
        endpointRouteBuilder.MapGet("/weatherforecast", () =>
        {
            return true;
        })
.WithName("GetWeatherForecast")
.WithOpenApi();
    }

}
