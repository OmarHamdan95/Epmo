﻿using Architecture.Model.Translation;

namespace Architecture.Model.Lookup;

public sealed record LookupModel
{
    public long Id { get; init; }
    public string? LookupCode { get; init; }
    public TranslationModel? Translation { get; init; }
    public LookupModel? Parent { get; init; }
    public long? Links { get; init; }
    public string? DataType { get; init; }
    public List<LookupValueModel>? LookupValues { get; init; }
}