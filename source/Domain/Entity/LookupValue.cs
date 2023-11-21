namespace Architecture.Domain;

public class LookupValue :  LookupBase
{
    public virtual long? LookupId { get; set; }
    public virtual Lookup? Lookup { get; set; }
    public virtual string? LookupValueCode { get; set; }
    public long? ParentId { get; set; }
    public virtual LookupValue? Parent { get; set; }
    public string? Description { get; set; }
    public long? Order { get; set; }
    public virtual bool IsSystem { get; set; }
    public string? Color { get; set; }
}
