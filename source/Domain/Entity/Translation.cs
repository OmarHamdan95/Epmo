namespace Architecture.Domain;

public class Translation : BaseAuditableEntity
{
   // public string? Code { get; set; }
    public List<TranslationValue>? TranslationValues { get; set; }

    public Translation(){}

    public Translation(long id) => Id = id;

    public Translation(List<TranslationValue> translationValues) => TranslationValues = TranslationValues;

}
