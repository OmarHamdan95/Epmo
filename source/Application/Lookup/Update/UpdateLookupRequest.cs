using System.Text.Json.Serialization;

namespace Epmo.Application;

public sealed record UpdateLookupRequest(LocalizedTextModel? TranslationModel ,
    List<LookupValueModel>? LookupValueModels , string? dataType ,  LookupModel? parent) : IRequest<Result>
{
    [JsonIgnore]
    public long Id { get; set; }
}
