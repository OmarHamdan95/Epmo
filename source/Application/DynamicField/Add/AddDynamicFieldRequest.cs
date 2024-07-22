namespace Epmo.Application;

public sealed record AddDynamicFieldRequest(long Id,
    LocalizedTextModel? Name,
    LookupValueModel? EntityType,
    LookupValueModel? DynamicFieldType,
    string? DynamicFieldRegex,
    long? DynamicFieldMinValue,
    long? DynamicFieldMaxValue,
    LookupValueModel? DynamicFieldLookupType) : IRequest<Result<long>>;
