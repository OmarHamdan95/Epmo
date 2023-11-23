namespace Epmo.Application;

public sealed record ListDynamicFieldRequest : IRequest<Result<IEnumerable<DynamicFieldModel>>>;
