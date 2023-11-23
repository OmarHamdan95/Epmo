namespace Epmo.Application;

public sealed record DeleteLookupRequest(long Id) : IRequest<Result>;
