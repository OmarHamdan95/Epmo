using Architecture.Model.Lookup;

namespace Architecture.Application;

public sealed record GridLanguageRequest : GridParameters , IRequest<Result<Grid<LanguageModel>>>;
