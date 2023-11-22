using Architecture.Model.Lookup;

namespace Architecture.Application;

public sealed record ListLanguageRequest : IRequest<Result<IEnumerable<LanguageModel>>>;
