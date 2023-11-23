namespace Epmo.Application;

public sealed record ListLookupRequest : IRequest<Result<IEnumerable<LookupModel>>>;
