using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace DesktopChat.Models
{
    internal class User
    {
        private int id;
        private string name;
        private string phone;
        private string password;
        private string image;
        private bool informationVisibility;
        private Contact[] contacts;
        private Chat[] chats;
        private GroupChat[] groupChats;
        
    }
}
