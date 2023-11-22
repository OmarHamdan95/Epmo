using System.Text.Json.Serialization;
using Architecture.Model.Lookup;
using Architecture.Model.Translation;

namespace Architecture.Application;

public sealed record UpdateTranslationRequest(List<TranslationValueModel>? translationValues) : IRequest<Result>
{
    [JsonIgnore]
    public long Id { get; set; }
}
