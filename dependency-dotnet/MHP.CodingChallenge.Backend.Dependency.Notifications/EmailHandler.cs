using System;
using MHP.CodingChallenge.Backend.Dependency.Inquiry;
using MHP.CodingChallenge.Backend.Dependency.Notifications.Abstract;
using Microsoft.Extensions.Logging;

namespace MHP.CodingChallenge.Backend.Dependency.Notifications
{
    public class EmailHandler : IEmailHandler
    {
        public virtual void SendEmail(IInquiry inquiry)
        {
            Console.WriteLine(string.Format("sending email for: {0}", inquiry.ToString()));
        }
    }
}