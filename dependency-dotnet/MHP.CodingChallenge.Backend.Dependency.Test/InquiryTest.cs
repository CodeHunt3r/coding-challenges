using Xunit;
using MHP.CodingChallenge.Backend.Dependency.Inquiry;
using Microsoft.Extensions.DependencyInjection;
using MHP.CodingChallenge.Backend.Dependency.Notifications;
using Moq;
using MHP.CodingChallenge.Backend.Dependency.Notifications.Abstract;

namespace MHP.CodingChallenge.Backend.Dependency.Test
{
    public class InquiryTest
    {
        [Fact]
        public void TestInquiryHandlers()
        {
            // given
            Inquiry.Inquiry inquiry = new Inquiry.Inquiry();
            inquiry.Username = "TestUser";
            inquiry.Recipient = "service@example.com";
            inquiry.Text = "Can I haz cheezburger?";

            // room for potential additional test setup
            var mockEmailHander = new Mock<EmailHandler>();
            var mockPushNotificationHandler = new Mock<PushNotificationHandler>();

            var services = new ServiceCollection()
                .AddLogging()
                // Inquiry Service registrieren dass er nachher mit GetRequiredService resolved werden kann (Zeile )
                .AddSingleton<InquiryService>()
                // Dependency Injection für IEmailHandler definieren, also immer wenn ein Konstruktor einen Übergabeparameter vom Typ IEmailHandler benötigt, wird 
                // an diesen Konsrtukor das gemockte Objekt "mockEmailHander.Object" übergeben
                .AddSingleton<IEmailHandler>(mockEmailHander.Object)
                // Dependency Injection für IPushNotificationHandler definieren, also immer wenn ein Konstruktor einen Übergabeparameter vom Typ IPushNotificationHandler
                // benötigt, wird an diesen Konsrtukor das gemockte Objekt "mockPushNotificationHandler.Object" übergeben
                .AddSingleton<IPushNotificationHandler>(mockPushNotificationHandler.Object)
                // Dependency Injection für IInquiry festlegen, weil diese in den KJonstruktoren von IEmailHandler und IPushNotificationHandler benötigt wird
                .AddScoped<IInquiry, Inquiry.Inquiry>();

            // Inquiry Service Instant holen
            var inquiryService = services
                .BuildServiceProvider()
                .GetRequiredService<InquiryService>();

            // when
            inquiryService.Create(inquiry);

            // then
            // Sicherstellen dass IEmailHanlder.SendEmail mit demselben inquiry Objekt aufgerufen wurde, wie inquiryService.Create(inquiry)
            mockEmailHander.Verify(e => e.SendEmail(inquiry));
            // Sicherstellen dass IPushNotificationHandler.SendNotification mit demselben inquiry Objekt aufgerufen wurde, wie inquiryService.Create(inquiry)
            mockPushNotificationHandler.Verify(e => e.SendNotification(inquiry));
        }
    }
}
