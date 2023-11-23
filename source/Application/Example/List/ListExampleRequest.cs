namespace Epmo.Application;

public sealed record ListExampleRequest : IRequest<Result<IEnumerable<ExampleModel>>>;
