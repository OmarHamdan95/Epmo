using System.Text.Json.Serialization;

namespace Epmo.Application;

public sealed record UpdateTranslationRequest(List<TranslationValueModel>? translationValues) : IRequest<Result>
{
    [JsonIgnore]
    public long Id { get; set; }
}
