namespace Architecture.Application;

public sealed record ListExampleRequest : IRequest<Result<IEnumerable<ExampleModel>>>;
