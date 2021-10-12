using System;

namespace EventBus
{
    class Subscriber
    {
        public void GetNotificationFromBankAccount(Object sender, System.EventArgs e)
        {
            Console.WriteLine("Receiver receives a notification: Sender recently has changed the bank account.");
        }
    }
}