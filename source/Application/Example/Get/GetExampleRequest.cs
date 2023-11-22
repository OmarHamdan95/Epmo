namespace Architecture.Application;

public sealed record GetExampleRequest(long Id) : IRequest<Result<ExampleModel>>;
