using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorPatternLibrary
{
    public abstract class  IUser
    {
        private IChatMediator chatMediator;
        private string name;

        public IUser(IChatMediator chatMediator, string name)
        {
            this.chatMediator = chatMediator;
            this.name = name;
        }

        public string Name
        {
            get
            {
                return name;
            }
        }

        public IChatMediator ChatMediator
        {
            get
            {
                return chatMediator;
            }
        }

        public abstract void SendMessage(string message);
        public abstract void ReceiveMessage(string message);
    }
}
