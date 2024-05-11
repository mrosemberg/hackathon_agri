namespace GrammaWebapi.Domain;

internal static class Extensions
{
    public static IServiceCollection AddDomain(this IServiceCollection services)
    {
        services.AddTransient<IWheatherServices, WheatherService>();
        //services.AddAutoMapper(Assembly.GetEntryAssembly());
        return services;
    }
}
