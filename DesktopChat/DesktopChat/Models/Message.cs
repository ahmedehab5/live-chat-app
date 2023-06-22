using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesktopChat.Models
{
    internal class Message
    {
        private int id;
        private string message;
        private DateTime dateTime;
        private bool isSent;
        private bool isSeen;
        private int senderId;
    }
}
