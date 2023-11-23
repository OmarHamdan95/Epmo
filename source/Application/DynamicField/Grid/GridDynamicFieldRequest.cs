namespace Epmo.Application;

public sealed record GridDynamicFieldRequest : GridParameters , IRequest<Result<Grid<DynamicFieldModel>>>;
