using Epmo.Domain.Common;

namespace Epmo.Domain;

public class LookupValue :  LookupBase
{
    public virtual Lookup? Lookup { get; set; }
    public virtual LookupValue? Parent { get; set; }
    public long? Order { get; set; }
    public virtual bool IsSystem { get; set; }
    public string? Color { get; set; }
    public virtual Translation? Translation { get; set; }
}
