namespace Architecture.Model.Translation;

public sealed record TranslationValueModel
{
    public long Id { get; init; }
    public string Code { get; init; }
    public string TransaltionValue { get; init; }
}
