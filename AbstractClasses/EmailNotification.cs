using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClasses
{
    class EmailNotification : Notification
    {
        public override void SendNotification(string message)
        {
            Console.WriteLine($"Sending message - '{message}' via email....");
        }
    }
}
