namespace Epmo.Application;

public sealed record InactivateLanguageRequest(long Id) : IRequest<Result>;
