using Architecture.Model.Lookup;
using Architecture.Model.Translation;
namespace Architecture.Application;

public  sealed record AddLookupRequest (string LookupCode,TranslationModel? TranslationModel ,
    List<LookupValueModel>? LookupValueModels , string? dataType ,  LookupModel? parent) : IRequest<Result<long>>;

