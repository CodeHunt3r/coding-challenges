using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MHP.CodingChallenge.Backend.Dependency.Notifications.Abstract
{
    public interface IInquiry
    {
        String Username { get; set; }
        String Recipient { get; set; }
        String Text { get; set; }
    }
}
