using Architecture.Model.Translation;

namespace Architecture.Model.Lookup;

public sealed record  LookupValueModel
{
    public long? Id { get; init; }
    public string? LookupCode { get; init; }
    public LookupValueParentModel? Parent { get; init; }
    public long? Order { get; init; }
    public TranslationModel? Translation { get; init; }
}

public sealed record LookupValueParentModel
{
    public long? Id { get; init; }
    public string? LookupCode { get; init; }
    public long? Order { get; init; }
    public TranslationModel? Translation { get; init; }
}
