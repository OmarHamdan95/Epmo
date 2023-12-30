using Mapster;
using StackExchange.Profiling.Storage;

namespace Epmo.Web;

public static class Extensions
{
    public static void ConfigureMapster(this IApplicationBuilder builder)
    {
        TypeAdapterConfig.GlobalSettings.Default.PreserveReference(true);
    }

    public static void AddProfiler(this IServiceCollection service)
    {
        service.AddMiniProfiler(option =>
        {
            option.RouteBasePath = "/api/profiler";
            option.ShowControls = true;
            option.PopupShowTrivial = true;
            option.StackMaxLength = 1000;
            ((option.Storage as MemoryCacheStorage)!).CacheDuration = TimeSpan.FromMinutes(60);
            option.SqlFormatter = new StackExchange.Profiling.SqlFormatters.SqlServerFormatter();
        }).AddEntityFramework();
    }
}
