namespace Epmo.Application;

public sealed record GridTranslationRequest : GridParameters , IRequest<Result<Grid<TranslationModelQuery>>>;
