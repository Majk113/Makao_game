using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MakaoGameNetLayer
{
    [Serializable]
    class Message
    {
        public MessageType type{ get; private set; }
        public string content { get; set; }

        public enum MessageType
        {
            SET_PLAYER_NAME,
            CHAT_MESSAGE,
            SYSTEM_MESSAGE
        }

        public Message(MessageType type, string content)
        {
            this.type = type;
            this.content = content;
        }
    }
}
