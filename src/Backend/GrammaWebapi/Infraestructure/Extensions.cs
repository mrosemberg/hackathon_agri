namespace GrammaWebapi;

internal static class Extensions
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services)
    {
        var config = services.GetConfiguration();

        services
            .AddTransient<IExcelsisApiClient, ExcelsisApiClient>()
            ;

        services.AddHttpClient("ApiExcelsis", httpClient =>
          {
              //httpClient.BaseAddress = new Uri(config["Endpoints:DatosClienteEndpoint"]!);
              //httpClient.DefaultRequestHeaders.Add("apikey", config["Parametros:ApiKey"]);
          });

        return services;
    }

    public static T GetOptions<T>(this IServiceCollection services, string sectionName) where T : class, new()
    {
        var configuration = services.GetConfiguration();

        return configuration.GetOptions<T>(sectionName);
    }

    public static T GetOptions<T>(this IConfiguration configuration, string sectionName) where T : class, new()
    {
        var options = new T();
        configuration.GetSection(sectionName).Bind(options);

        return options;
    }

    public static IConfiguration GetConfiguration(this IServiceCollection services)
    {
        using var scope = services.BuildServiceProvider().CreateScope();
        var configuration = scope.ServiceProvider.GetRequiredService<IConfiguration>();

        return configuration;
    }
}


