using ConsoleApp1.Interface_SOLID;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            // SRP
            Logger logger = new FileLogger();
            logger.Log("This is a log message");

            // OCP
            Shape shape = new Circle();
            ShapeDrawer shapeDrawer = new ShapeDrawer();
            shapeDrawer.DrawShape(shape);

            // LSP
            Bird bird = new Eagle();
            BirdFlightSimulator birdFlightSimulator = new BirdFlightSimulator();
            birdFlightSimulator.SimulateFlight(bird);

            // ISP
            IPrinter printer = new MultifunctionalDevice();
            printer.Print();

            // DIP
            IEmailService emailService = new EmailService();
            NotificationService notificationService = new NotificationService(emailService);
            notificationService.SendNotification("user@example.com", "Hello, world!");
            Console.ReadLine();
        }
    }
}
