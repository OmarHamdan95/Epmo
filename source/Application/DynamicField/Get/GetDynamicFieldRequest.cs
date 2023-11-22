
namespace Architecture.Application;

public sealed record GetDynamicFieldRequest(long Id) : IRequest<Result<DynamicFieldModel>>;
