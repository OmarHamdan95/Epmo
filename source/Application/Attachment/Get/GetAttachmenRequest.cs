
namespace Epmo.Application;

public sealed record GetAttachmenRequest(long Id) : IRequest<Result<AttachemntGroupModel>>;
