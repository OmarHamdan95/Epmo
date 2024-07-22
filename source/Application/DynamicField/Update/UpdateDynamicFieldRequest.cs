using System.Text.Json.Serialization;

namespace Epmo.Application;

public sealed record UpdateDynamicFieldRequest(LocalizedTextModel? Name,
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
