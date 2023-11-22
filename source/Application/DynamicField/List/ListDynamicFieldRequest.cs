using Architecture.Model.Lookup;

namespace Architecture.Application;

public sealed record ListDynamicFieldRequest : IRequest<Result<IEnumerable<DynamicFieldModel>>>;
