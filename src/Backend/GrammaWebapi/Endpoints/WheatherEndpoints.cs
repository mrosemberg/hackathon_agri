
using System.Net;

namespace GrammaWebapi;

public class WheatherEndpoints : IEndpointDefinition
{
    public IExcelsisApiClient _excelsisApiClient;
    public WheatherEndpoints(IExcelsisApiClient excelsisApiClient)
    {
        this._excelsisApiClient = excelsisApiClient;
    }
    public void DefineEndpoints(WebApplication app)
    {
        app.MapGet("v1/api/wheather-forecast", ObtenerClima)
            .WithTags("[Wheather Forecast")
            .Produces((int)HttpStatusCode.OK)
            .Produces(StatusCodes.Status204NoContent);
    }

    internal static async Task<IResult> ObtenerClima()
    {
        return Results.Ok(null);
    }

    public void DefineServices(IServiceCollection services)
    {
        throw new NotImplementedException();
    }
}
