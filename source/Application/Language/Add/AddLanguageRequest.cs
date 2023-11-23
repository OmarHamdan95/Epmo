namespace Epmo.Application;

public  sealed record AddLanguageRequest (string? Code , string? LangFlag) : IRequest<Result<long>>;

