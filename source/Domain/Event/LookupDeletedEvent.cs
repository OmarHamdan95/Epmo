using Epmo.Domain.Common;

namespace Epmo.Domain.Event;

public class LookupDeletedEvent : BaseEvent
{
    public LookupDeletedEvent(Lookup item)
    {
        Item = item;
    }

    public Lookup Item { get; }
}
