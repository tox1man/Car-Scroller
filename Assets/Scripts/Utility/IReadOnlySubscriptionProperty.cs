using System;

namespace Utility
{
    internal interface IReadOnlySubscriptionProperty<T> 
    {
        T Value { get; }
        void SubscribeOnChange(Action<T> subscribtionAction);
        void UnsubscribeOnChange(Action<T> unsubscribtionAction);
    }
}
