using Architecture.Domain.Common;

namespace Architecture.Domain.Event;

public class LookupValueDeletedEvent : BaseEvent
{
    public LookupValueDeletedEvent(LookupValue item)
    {
        Item = item;
    }

    public LookupValue Item { get; }
}
