using System;

namespace EventBus.Common.Interfaces
{
    public interface ISubscription<TMessage> : IDisposable where TMessage : IMessage
    {
        Action<TMessage> Action { get; }
        IEventAggregator EventAggregator { get; }
    }
}
