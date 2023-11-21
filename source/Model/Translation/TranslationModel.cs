namespace Architecture.Model.Translation;

public sealed record TranslationModel
{
    public long Id { get; init; }
    public string Code { get; init; }
    public List<TranslationValueModel> TranslationValues { get; init; }
}
