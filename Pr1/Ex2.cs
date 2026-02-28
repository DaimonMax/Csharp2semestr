using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr1
{
    internal class Ex2
    {
        internal static void RunEx2()
        {
            NotificationHandler text = SendEmail;
            text += SendSMS;
            text("Message here!");
            Console.WriteLine("---------------------------------------------------");
        }

        private delegate void NotificationHandler(string message);

        private static void SendEmail(string message)
        {
            Console.WriteLine($"Email sent: {message}");
        }

        private static void SendSMS(string message)
        {
            Console.WriteLine($"SMS sent: {message}");
        }
    }
}
