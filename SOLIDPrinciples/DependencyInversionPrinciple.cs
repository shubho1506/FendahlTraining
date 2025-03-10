using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDPrinciples
{
    class DependencyInversionPrinciple
    {
        public interface IMessageService
        {
            void SendMessage();
        }

        public class EmailService : IMessageService
        {
            public void SendMessage() => Console.WriteLine("Sending Email...");
        }

        public class SMSService : IMessageService
        {
            public void SendMessage() => Console.WriteLine("Sending SMS...");
        }

        public class Notification
        {
            private readonly IMessageService messageService;

            public Notification(IMessageService messageService)
            {
                this.messageService = messageService;
            }

            public void NotifyUser()
            {
                messageService.SendMessage();
            }
        }

    }
}
