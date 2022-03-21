using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MHP.CodingChallenge.Backend.Dependency.Notifications.Abstract
{
    public interface IPushNotificationHandler
    {
        void SendNotification(IInquiry inquiry);
    }
}
