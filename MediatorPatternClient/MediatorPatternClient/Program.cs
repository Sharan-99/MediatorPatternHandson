using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatorPatternLibrary;

namespace MediatorPatternClient
{
    class Program
    {
        static void Main(string[] args)
        {
            IChatMediator chatMediator = new ChatMediator();

            IUser user1=new BasicUser(chatMediator, "Gokul");
            IUser user2=new PremiumUser(chatMediator, "Syed");
            IUser user3 = new PremiumUser(chatMediator, "Aravindh");
            chatMediator.AddUser(user1);
            chatMediator.AddUser(user2);
            chatMediator.AddUser(user3);
            
            IUser user4 = new BasicUser(chatMediator, "Sharan");
            chatMediator.AddUser(user4);

            user4.SendMessage("This is a message...Hello!");
     
            Console.ReadKey();
        }
    }
}
