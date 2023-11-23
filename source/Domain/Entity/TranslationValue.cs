using System.ComponentModel.DataAnnotations.Schema;
using Epmo.Domain.Common;

namespace Epmo.Domain;

public class TranslationValue : BaseAuditableEntity
{
    public Translation? Translation { get; set; }
    public string? TransaltionValue { get; set; }
    private Language? Language { get; set; }
    public long? LanguageId { get; set; }
}
