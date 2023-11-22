using Architecture.Model.Lookup;
using Architecture.Model.Translation;

namespace Architecture.Application;

public sealed record GridTranslationRequest : GridParameters , IRequest<Result<Grid<TranslationModelQuery>>>;
