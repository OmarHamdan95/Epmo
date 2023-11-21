using Architecture.Model.Translation;

namespace Architecture.Model.Lookup;

public class LookupValueModel
{
    public long Id { get; init; }

    public string LookupCode { get; init; }

    public TranslationModel TranslationModel { get; init; }
}
