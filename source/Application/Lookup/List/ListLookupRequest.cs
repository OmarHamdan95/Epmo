using Architecture.Model.Lookup;

namespace Architecture.Application;

public sealed record ListLookupRequest : IRequest<Result<IEnumerable<LookupModel>>>;
