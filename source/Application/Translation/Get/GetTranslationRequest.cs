
using Architecture.Model.Translation;

namespace Architecture.Application;

public sealed record GetTranslationRequest(long Id) : IRequest<Result<TranslationModelQuery>>;
