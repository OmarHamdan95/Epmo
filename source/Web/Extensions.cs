using Mapster;

namespace Architecture.Web;

public static class Extensions
{
    public static void ConfigureMapster(this IApplicationBuilder builder)
    {
        TypeAdapterConfig.GlobalSettings.Default.PreserveReference(true);
    }
}
