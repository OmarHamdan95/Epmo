﻿using Epmo.Domain.Common;

namespace Epmo.Domain.Event;

public class LookupValueDeletedEvent : BaseEvent
{
    public LookupValueDeletedEvent(LookupValue item)
    {
        Item = item;
    }

    public LookupValue Item { get; }
}
