using System;

namespace MHP.CodingChallenge.Backend.Dependency.Notifications.Abstract
{
    public interface IEmailHandler
    {
        void SendEmail(IInquiry inquiry);
    }
}
