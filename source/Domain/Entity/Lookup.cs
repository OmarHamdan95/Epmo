namespace Architecture.Domain;

public class Lookup : BaseAuditableEntity
{
    public long? ParentId { get; set; }
    public virtual Lookup? Parent { get; set; }
    public long? Links { get; set; }
    public virtual List<LookupValue>? LookupValues { get; set; }
    public virtual bool IsSystem { get; set; }
    public virtual string? DataType { get; set; }
    public virtual string? LookupCode { get; set; }

}
