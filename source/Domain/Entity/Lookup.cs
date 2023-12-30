namespace Epmo.Domain;

public class Lookup : LookupBase ,IAggregateRoot
{
    public Lookup(){}

    public Lookup(string? code, Translation? translation ,
        string? dataType , long? parentId)
    {
        Code = code;
        Translation = translation;
        DataType = dataType;
        ParentId = parentId;
        ValidFrom = DateTime.Now;
        // _lookupValues = lookupValues;
    }

    public void AddLookupValue(LookupValue lookupValue)
    {
        _lookupValues.Add(lookupValue);
    }

    public Lookup(long id) => Id = id;
    public virtual Lookup? Parent { get; set; }
    public long? ParentId { get; set; }
    public long? Links { get; set; }
    public List<LookupValue>? _lookupValues = new List<LookupValue>();
    public virtual IReadOnlyCollection<LookupValue> LookupValues =>
        _lookupValues.AsReadOnly();

    public virtual bool IsSystem { get; set; }
    public virtual string? DataType { get; set; }


    public void UpdateLookup(Translation? translation, List<LookupValue>? lookupValues, string? dataType,
        Lookup? parent)
    {
        Translation = translation;
        _lookupValues = lookupValues;
        DataType = dataType;
        Parent = parent;
    }

    public void Inactivate() => ValidTo = DateTime.Now.AddDays(-1);
}
