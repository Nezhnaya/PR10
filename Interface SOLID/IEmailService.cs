using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Interface_SOLID
{
    // Dependency Inversion Principle (DIP)
    public interface IEmailService
    {
        void SendEmail(string recipient, string message);
    }

    public class EmailService : IEmailService
    {
        public void SendEmail(string recipient, string message)
        {
            Console.WriteLine($"Sending email to {recipient}: {message}");
        }
    }

    public class NotificationService
    {
        private readonly IEmailService _emailService;

        public NotificationService(IEmailService emailService)
        {
            _emailService = emailService;
        }

        public void SendNotification(string recipient, string message)
        {
            _emailService.SendEmail(recipient, message);
        }
    }
}
