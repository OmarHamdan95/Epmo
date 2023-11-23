namespace Epmo.Application;

public sealed record GetLookupRequest(long Id) : IRequest<Result<LookupModel>>;
