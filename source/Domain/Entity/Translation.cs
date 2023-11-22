namespace Architecture.Domain;

public class Translation : BaseAuditableEntity
{
   // public string? Code { get; set; }
    public List<TranslationValue>? TranslationValues { get; private set; }

    public Translation(){}

    public Translation(long id) => Id = id;

    public Translation(List<TranslationValue> translationValues) => TranslationValues = translationValues;

    public Translation(string code, List<TranslationValue> translationValues)
    {
        TranslationValues = translationValues;
        Code = code;
    }

    public void UpdateTranslation(List<TranslationValue> translationValues)
    {
        TranslationValues = translationValues;
    }

}
