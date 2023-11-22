using System.Text.Json.Serialization;
using Architecture.Model.Lookup;
using Architecture.Model.Translation;

namespace Architecture.Application;

public sealed record UpdateDynamicFieldRequest(TranslationModel? Name,
    LookupValueModel? EntityType,
    LookupValueModel? DynamicFieldType,
    string? DynamicFieldRegex,
    long? DynamicFieldMinValue,
    long? DynamicFieldMaxValue,
    LookupValueModel? DynamicFieldLookupType) : IRequest<Result>
{
    [JsonIgnore]
    public long Id { get; set; }
}
