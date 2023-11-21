using Architecture.Domain.Common;

namespace Architecture.Domain.Event;

public class LookupValueCreatedEvent : BaseEvent
{
    public LookupValueCreatedEvent(LookupValue item)
    {
        Item = item;
    }
    public LookupValue Item;
}
