using EventBus.Common;
using EventBus.Common.Messages;
using System;

namespace EventBus
{
    class Program
    {
        static void Main(string[] args)
        {
            ClassA classA = new ClassA();
            ClassB classB = new ClassB();

            classA.Publish();
            classB.Publish();
            Console.ReadKey();
        }
    }

    class ClassA
    {
        public ClassA()
        {
            EventAggregator.Instance.Subscribe<MessageB>(@params => { MessageBNotification(@params); });
        }

        public void Publish()
        {
            EventAggregator.Instance.Publish(new MessageA() { });
        }

        private void MessageBNotification(MessageB message)
        {
            Console.WriteLine($"A Received a notification from: {message.LogMessage}");
        }
    }

    class ClassB
    {
        public ClassB()
        {
            EventAggregator.Instance.Subscribe<MessageA>(@params => { MessageANotification(@params); });
        }

        public void Publish()
        {
            EventAggregator.Instance.Publish(new MessageB(){ });
        }

        private void MessageANotification(MessageA message)
        {
            Console.WriteLine($"B Received a notification from: {message.LogMessage}");
        }
    }

}
