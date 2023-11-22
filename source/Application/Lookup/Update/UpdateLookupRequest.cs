using System.Text.Json.Serialization;
using Architecture.Model.Lookup;
using Architecture.Model.Translation;

namespace Architecture.Application;

public sealed record UpdateLookupRequest(TranslationModel? TranslationModel ,
    List<LookupValueModel>? LookupValueModels , string? dataType ,  LookupModel? parent) : IRequest<Result>
{
    [JsonIgnore]
    public long Id { get; set; }
}
