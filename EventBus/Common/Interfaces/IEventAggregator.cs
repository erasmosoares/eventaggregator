using System;

namespace EventBus.Common.Interfaces
{
    public interface IEventAggregator
    {
        void Publish<TMessage>(TMessage message) where TMessage : IMessage;
        void Subscribe<TMessage>(Action<TMessage> action) where TMessage : IMessage;
        void UnSubscribe<TMessage>(ISubscription<TMessage> subscription) where TMessage : IMessage;
        void ClearAllSubscriptions();
        void ClearAllSubscriptions(Type[] exceptMessages);
    }
}
