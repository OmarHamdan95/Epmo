﻿namespace Epmo.Application;

public  sealed record AddLookupRequest (string LookupCode,TranslationModel? TranslationModel ,
    List<LookupValueModel>? LookupValueModels , string? dataType ,  LookupModel? parent) : IRequest<Result<long>>;

