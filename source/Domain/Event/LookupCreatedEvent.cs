using Architecture.Domain.Common;

namespace Architecture.Domain.Event;

public class LookupCreatedEvent : BaseEvent
{
    public LookupCreatedEvent(Lookup item)
    {
        Item = item;
    }
    public Lookup Item;
}
