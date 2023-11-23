namespace Epmo.Application;

public sealed record ListLanguageRequest : IRequest<Result<IEnumerable<LanguageModel>>>;
