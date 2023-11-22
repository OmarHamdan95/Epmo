using Architecture.Model.Lookup;
using Architecture.Model.Translation;
namespace Architecture.Application;

public  sealed record AddLanguageRequest (string? Code , string? LangFlag) : IRequest<Result<long>>;

