namespace Architecture.Application;

public sealed record DeleteSystemMenuRequest(long Id) : IRequest<Result>;
