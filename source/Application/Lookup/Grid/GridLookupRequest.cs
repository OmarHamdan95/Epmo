using Architecture.Model.Lookup;

namespace Architecture.Application;

public sealed record GridLookupRequest : GridParameters , IRequest<Result<Grid<LookupModel>>>;
