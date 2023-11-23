namespace Epmo.Application;

public sealed record AddExampleRequest(string Name) : IRequest<Result<long>>;
