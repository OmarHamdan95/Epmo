namespace Epmo.Domain;

public class LookupValue : LookupBase
{
    public virtual Lookup? Lookup { get; set; }
    public virtual LookupValue? Parent { get; set; }
    public long? ParentId { get; set; }
    public long? Order { get; set; }
    public virtual bool IsSystem { get; set; }
    public string? Color { get; set; }


    public LookupValue()
    {
    }

    public LookupValue(long id) => Id = id;

    public LookupValue(string code, long? order, string? color, Translation translation, long? parentId)
    {
        Code = code;
        Order = order;
        Color = color;
        Translation = translation;
        ParentId = parentId;
    }
}
