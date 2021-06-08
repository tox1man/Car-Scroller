using System;

namespace Utility
{
    internal class SubscriptionAction : IReadOnlySubcriptionAction
    {
        private Action _action;
        
        public void Invoke()
        {
            _action?.Invoke();
        }
        public void SubscribeOnChange(Action subscribeAction)
        {
            _action += subscribeAction;
        }

        public void UnsubscribeOnChange(Action unsubscribeAction)
        {
            _action -= unsubscribeAction;
        }
    }
}
