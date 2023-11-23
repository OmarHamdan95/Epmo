namespace Epmo.Application;

public sealed record DeleteLanguageRequest(long Id) : IRequest<Result>;
