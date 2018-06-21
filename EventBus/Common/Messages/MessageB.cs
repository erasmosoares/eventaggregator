using EventBus.Common.Interfaces;

namespace EventBus.Common.Messages
{
    public class MessageB : IMessage
    {
        private string _msg = "B";

        public string LogMessage
        {
            get { return _msg; }
            set { _msg = value; }
        }
    }
}
