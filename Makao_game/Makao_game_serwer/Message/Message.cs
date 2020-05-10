using System;

namespace MakaoGameNetLayer
{
    [Serializable]
    public class Message
    {
        public MessageType type { get; private set; }
        public string name { get; private set; }
        public string msg { get; private set; }

        public enum MessageType
        {
            SET_PLAYER_NAME,
            CHAT_MESSAGE,
            SYSTEM_MESSAGE
        }

        public Message(MessageType type, string name)
        {
            this.type = type;
            this.name = name;
        }

        public Message(MessageType type, string name, string msg)
        {
            this.type = type;
            this.name = name;
            this.msg = msg;
        }

    }
}
