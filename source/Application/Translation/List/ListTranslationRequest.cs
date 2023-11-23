namespace Epmo.Application;

public sealed record ListTranslationRequest : IRequest<Result<IEnumerable<TranslationModelQuery>>>;
