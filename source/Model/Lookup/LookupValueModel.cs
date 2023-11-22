using Architecture.Model.Translation;

namespace Architecture.Model.Lookup;

public class LookupValueModel
{
    public long? Id { get; init; }
    public string? LookupCode { get; init; }

    public LookupValueModel? Parent { get; init; }

    public long? Order { get; init; }
    public TranslationModel? Translation { get; init; }
}
