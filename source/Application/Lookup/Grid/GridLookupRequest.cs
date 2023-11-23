namespace Epmo.Application;

public sealed record GridLookupRequest : GridParameters , IRequest<Result<Grid<LookupModel>>>;
