using EventBus.Common.Interfaces;

namespace EventBus.Common.Messages
{
    public class MessageA : IMessage
    {
        private string _msg = "A";

        public string LogMessage
        {
            get { return _msg; }
            set { _msg = value; }
        }
    }
}
