namespace Epmo.Domain;

public class Lookup : LookupBase
{
    public Lookup(){}

    public Lookup(string? lookupCode, Translation? translation , List<LookupValue>? lookupValues , string? dataType , Lookup? parent)
    {
        Translation = translation;
        LookupValues = lookupValues;
        DataType = dataType;
        Parent = parent;
        ValidFrom = DateTime.Now;
    }

    public Lookup(long id) => Id = id;
    public virtual Lookup? Parent { get; set; }
    public long? Links { get; set; }
    public virtual List<LookupValue>? LookupValues { get; set; }
    public virtual bool IsSystem { get; set; }
    public virtual string? DataType { get; set; }
    public virtual Translation? Translation { get; set; }


    public void UpdateLookup(Translation? translation, List<LookupValue>? lookupValues, string? dataType,
        Lookup? parent)
    {
        Translation = translation;
        LookupValues = lookupValues;
        DataType = dataType;
        Parent = parent;
    }

    public void Inactivate() => ValidTo = DateTime.Now.AddDays(-1);
}
