using System.Text.Json.Serialization;

namespace Epmo.Application;

public sealed record UpdateLookupRequest(TranslationModel? TranslationModel ,
    List<LookupValueModel>? LookupValueModels , string? dataType ,  LookupModel? parent) : IRequest<Result>
{
    [JsonIgnore]
    public long Id { get; set; }
}
