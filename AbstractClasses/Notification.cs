using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClasses
{
    //Scenario 4: Notification System
    //A company sends notifications via Email, SMS, and Push Notification.
    //Each notification type has a method SendNotification(string message).
    //Question:
    //Create an abstract class Notification with an abstract method SendNotification().
    //Implement EmailNotification, SMSNotification, and PushNotification classes with their own sending logic.
    abstract class Notification
    {
        public abstract void SendNotification(string message);
    }
}
