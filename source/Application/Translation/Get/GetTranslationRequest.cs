namespace Epmo.Application;

public sealed record GetTranslationRequest(long Id) : IRequest<Result<TranslationModelQuery>>;
