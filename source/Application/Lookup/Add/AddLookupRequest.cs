namespace Epmo.Application;

public  sealed record AddLookupRequest (string Code,LocalizedTextModel? TranslationModel ,
    List<LookupValueModel>? LookupValueModels , string? dataType ,  LookupModel? parent) : IRequest<Result<long>>;
