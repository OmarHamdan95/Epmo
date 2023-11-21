namespace Architecture.Domain;

public class TranslationValue : BaseAuditableEntity
{
    public Translation? Translation { get; set; }
    public string? TransaltionValue { get; set; }
}
