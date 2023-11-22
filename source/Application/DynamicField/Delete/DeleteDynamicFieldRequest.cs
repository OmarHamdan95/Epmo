namespace Architecture.Application;

public sealed record DeleteDynamicFieldRequest(long Id) : IRequest<Result>;
