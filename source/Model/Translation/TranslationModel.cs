namespace Architecture.Model.Translation;

public sealed record TranslationModel
{
    public long Id { get; init; }
    public string Code { get; init; }
    public List<TranslationValueModel> TranslationValues { get; init; }
}


public sealed record TranslationModelQuery
{
    public long Id { get; init; }
    public string Code { get; init; }
    public List<TranslationValueModelQuery> TranslationValues { get; init; }
}
