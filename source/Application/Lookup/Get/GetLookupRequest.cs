using Architecture.Model.Lookup;

namespace Architecture.Application;

public sealed record GetLookupRequest(long Id) : IRequest<Result<LookupModel>>;
