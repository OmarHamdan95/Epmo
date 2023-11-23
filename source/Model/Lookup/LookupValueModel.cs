
namespace Epmo.Model;

public sealed record  LookupValueModel
{
    public long? Id { get; init; }
    public LookupValueParentModel? Parent { get; init; }
    public long? Order { get; init; }
    public TranslationModel? Translation { get; init; }
}

public sealed record LookupValueParentModel
{
    public long? Id { get; init; }
    public long? Order { get; init; }
    public TranslationModel? Translation { get; init; }
}
