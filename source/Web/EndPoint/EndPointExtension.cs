
namespace Epmo.Web;

public static class EndPointExtension
{
    public static void RegisterEndPoints(this IEndpointRouteBuilder routes)
    {
        routes.RegisterAuthEndPoints();
        routes.RegisterAttachmentEndpoints();
    }




}
