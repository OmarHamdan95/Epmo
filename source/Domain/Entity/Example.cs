using Epmo.Domain.Common;

namespace Epmo.Domain;

public sealed class Example : BaseAuditableEntity
{
    public Example(long id, string name) : this(name) => Id = id;

    public Example(string name) => Name = name;

    public string Name { get; }
}
