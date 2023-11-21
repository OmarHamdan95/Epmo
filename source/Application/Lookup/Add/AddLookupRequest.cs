using Architecture.Model.Translation;

namespace Architecture.Application.Lookup.Add;

public  sealed record AddLookupRequest (string LookupCode,TranslationModel TranslationModel);

