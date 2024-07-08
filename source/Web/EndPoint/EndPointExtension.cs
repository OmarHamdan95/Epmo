// using MediatR;
//
// namespace Epmo.Web.EndPoint;
//
// public static class EndPointExtension
// {
//     public static void RegisterAttachmentEndpoints(this IEndpointRouteBuilder routes)
//     {
//         var attachemnt = routes.MapGroup("/api/attachemnt");
//
//         attachemnt.MapPost("", (IMediator mediator, AddAttachmenRequest request) =>
//         {
//              mediator.Send(request).ApiResult();
//         });
//
//         // attachemnt.MapGet("test", (IMediator mediator, AddAttachmenRequest request) =>
//         // {
//         //     mediator.Send(request).ApiResult();
//         // });
//
//         //users.MapPost("", (AddAttachmenRequest request) => Mediator.Send(request).ApiResult());
//     }
// }
