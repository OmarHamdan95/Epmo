namespace Epmo.Application;

public sealed record DeleteDynamicFieldRequest(long Id) : IRequest<Result>;
