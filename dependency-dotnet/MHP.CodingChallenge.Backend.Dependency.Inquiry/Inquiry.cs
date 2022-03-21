using MHP.CodingChallenge.Backend.Dependency.Notifications.Abstract;
using System;

namespace MHP.CodingChallenge.Backend.Dependency.Inquiry
{
    public class Inquiry : IInquiry
    {
        public String Username { get; set; }
        public String Recipient { get; set; }
        public String Text { get; set; }

        public override String ToString()
        {
            return "Inquiry{" +
                    "username='" + Username + '\'' +
                    ", recipient='" + Recipient + '\'' +
                    ", text='" + Text + '\'' +
                    '}';
        }

        public override bool Equals(Object o)
        {
            if (this == o) return true;
            if (o == null || GetType() != o.GetType()) return false;
            Inquiry inquiry = (Inquiry)o;
            return Object.Equals(Username, inquiry.Username) &&
                    Object.Equals(Recipient, inquiry.Recipient) &&
                    Object.Equals(Text, inquiry.Text);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Username, Recipient, Text);
        }
    }


}
