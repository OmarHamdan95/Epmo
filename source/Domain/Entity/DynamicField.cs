namespace Architecture.Domain;

public class DynamicField : BaseAuditableEntity
{
    public Translation? Name { get; set; }
    public LookupValue? EntityType { get; set; }
    public LookupValue? DynamicFieldType { get; set; }
    public string? DynamicFieldRegex { get; set; }
    public long? DynamicFieldMinValue { get; set; }
    public long? DynamicFieldMaxValue { get; set; }
    public LookupValue? DynamicFieldLookupType { get; set; }


    public DynamicField()
    {
    }

    public DynamicField(long id) => Id = id;

    public DynamicField(Translation? name, LookupValue? entityType, LookupValue? dynamicFieldType,
        string? dynamicFieldRegex, long? dynamicFieldMinValue, long? dynamicFieldMaxValue,
        LookupValue? dynamicFieldLookupType)
    {
        Name = name;
        EntityType = entityType;
        DynamicFieldType = dynamicFieldType;
        DynamicFieldRegex = dynamicFieldRegex;
        DynamicFieldMinValue = dynamicFieldMinValue;
        DynamicFieldMaxValue = dynamicFieldMaxValue;
        DynamicFieldLookupType = dynamicFieldLookupType;
    }


    public void UpdateDynamicField(Translation? name, LookupValue? entityType, LookupValue? dynamicFieldType,
        string? dynamicFieldRegex, long? dynamicFieldMinValue, long? dynamicFieldMaxValue,
        LookupValue? dynamicFieldLookupType)
    {
        Name = name;
        EntityType = entityType;
        DynamicFieldType = dynamicFieldType;
        DynamicFieldRegex = dynamicFieldRegex;
        DynamicFieldMinValue = dynamicFieldMinValue;
        DynamicFieldMaxValue = dynamicFieldMaxValue;
        DynamicFieldLookupType = dynamicFieldLookupType;
    }
}
