namespace Architecture.Application;

public sealed record DeleteExampleRequest(long Id) : IRequest<Result>;
