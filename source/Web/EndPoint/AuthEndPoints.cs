
namespace Epmo.Web;

public  static class AuthEndPoints
{
    public static void RegisterAuthEndPoints(this IEndpointRouteBuilder routes)
    {
        var auth = routes.MapGroup("/api/auths").RequireAuthorization();

        auth.MapPost("",
            [AllowAnonymous](IMediator mediator, AuthRequest request) =>
            {
                return Results.Ok(mediator.Send(request).ApiResult());
            });
    }
}
