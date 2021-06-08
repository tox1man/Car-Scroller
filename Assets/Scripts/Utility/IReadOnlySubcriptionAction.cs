using System;

namespace Utility
{
    internal interface IReadOnlySubcriptionAction
    {
        void SubscribeOnChange(Action subscribeAction);
        void UnsubscribeOnChange(Action UnsubscribeAction);
    }
}
