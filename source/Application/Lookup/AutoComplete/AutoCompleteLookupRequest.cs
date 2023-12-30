namespace Epmo.Application;

public sealed record AutoCompleteLookupRequest(string? lookupCode , string? text) : IRequest<Result<IEnumerable<LookupValueModel>>>;
