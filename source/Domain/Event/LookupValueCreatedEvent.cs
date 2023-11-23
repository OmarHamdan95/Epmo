using Epmo.Domain.Common;

namespace Epmo.Domain.Event;

public class LookupValueCreatedEvent : BaseEvent
{
    public LookupValueCreatedEvent(LookupValue item)
    {
        Item = item;
    }
    public LookupValue Item;
}
