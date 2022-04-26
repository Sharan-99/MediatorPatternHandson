using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorPatternLibrary
{
    public interface IChatMediator
    {
        void AddUser(IUser user);
        void SendMessageToAllUsers(string message, IUser currentUsr);
    }
}
