using System;
using MHP.CodingChallenge.Backend.Dependency.Inquiry;
using MHP.CodingChallenge.Backend.Dependency.Notifications.Abstract;
using Microsoft.Extensions.Logging;

namespace MHP.CodingChallenge.Backend.Dependency.Notifications
{
    public class PushNotificationHandler : IPushNotificationHandler
    {
        public virtual void SendNotification(IInquiry inquiry)
        {
            Console.WriteLine(string.Format("sending notification inquiry: {0}", inquiry.ToString()));
        }
    }
}
