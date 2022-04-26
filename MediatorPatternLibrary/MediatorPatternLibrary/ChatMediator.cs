using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorPatternLibrary
{
   public class ChatMediator:IChatMediator
   {
        List<IUser> users;
        public ChatMediator()
        {
            users = new List<IUser>();
        }

        public void AddUser(IUser user)
        {
            users.Add(user);
        }

        public void SendMessageToAllUsers(string message, IUser currentUsr)
        {
            users.ForEach(w => { if (w != currentUsr)                                //don't send message to sender
                                 {
                                     w.ReceiveMessage(message);
                                 }  });
        }
    }
}
