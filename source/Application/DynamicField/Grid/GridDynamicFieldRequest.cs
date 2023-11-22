using Architecture.Model.Lookup;

namespace Architecture.Application;

public sealed record GridDynamicFieldRequest : GridParameters , IRequest<Result<Grid<DynamicFieldModel>>>;
