using Architecture.Model.Lookup;
using Architecture.Model.Translation;

namespace Architecture.Application;

public sealed record ListTranslationRequest : IRequest<Result<IEnumerable<TranslationModelQuery>>>;
