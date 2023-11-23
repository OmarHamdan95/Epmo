namespace Epmo.Application;

public sealed record GetExampleRequest(long Id) : IRequest<Result<ExampleModel>>;
