namespace Epmo.Application;

public sealed record AddDynamicFieldRequest(long Id,
    TranslationModel? Name,
    LookupValueModel? EntityType,
    LookupValueModel? DynamicFieldType,
    string? DynamicFieldRegex,
    long? DynamicFieldMinValue,
    long? DynamicFieldMaxValue,
    LookupValueModel? DynamicFieldLookupType) : IRequest<Result<long>>;
