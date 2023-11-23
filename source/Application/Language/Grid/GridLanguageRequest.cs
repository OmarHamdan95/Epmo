namespace Epmo.Application;

public sealed record GridLanguageRequest : GridParameters , IRequest<Result<Grid<LanguageModel>>>;
