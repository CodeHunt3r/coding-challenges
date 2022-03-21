using System;
using MHP.CodingChallenge.Backend.Dependency.Notifications.Abstract;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace MHP.CodingChallenge.Backend.Dependency.Inquiry
{
    public class InquiryService 
    {
        private IEmailHandler _emailHandler;
        private IPushNotificationHandler _pushNotificationHandler;

        /// <summary>
        /// Konstruktor für Dependency Injections <see cref="https://docs.microsoft.com/en-us/aspnet/core/fundamentals/dependency-injection?view=aspnetcore-6.0"/>
        /// Die Übergabeparameter werden "injected". Konfiguration dafür ist in der Startup Klasse 
        /// </summary>
        public InquiryService(IEmailHandler emailHandler, IPushNotificationHandler pushNotificationHandler)
        {
            _emailHandler = emailHandler;
            _pushNotificationHandler = pushNotificationHandler;
        }

        public void Create(IInquiry inquiry)
        {
            Console.WriteLine(string.Format("User sent inquiry: {0}", inquiry.ToString()));
            _emailHandler.SendEmail(inquiry);
            _pushNotificationHandler.SendNotification(inquiry);
        }
    }
}
