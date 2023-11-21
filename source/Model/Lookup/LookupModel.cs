using Architecture.Model.Translation;

namespace Architecture.Model.Lookup;

public sealed record LookupModel
{
    public long Id { get; init; }

    public string LookupCode { get; init; }

    public TranslationModel TranslationModel { get; init; }

    public List<LookupValueModel> LookupValueModels { get; init; }
}
