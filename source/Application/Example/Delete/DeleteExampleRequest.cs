namespace Epmo.Application;

public sealed record DeleteExampleRequest(long Id) : IRequest<Result>;
