namespace Epmo.Application;

public sealed record DeleteAttachmenRequest(long Id) : IRequest<Result>;
