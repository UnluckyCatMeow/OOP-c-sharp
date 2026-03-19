using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr1
{
    public delegate void NotificationHandler(string message);
    public class Multicasting
    {
        public void Example()
        {
            NotificationHandler handler = SendEmail;
            handler += SendSMS;
            handler("йопт, на шо я жмал?");
        }

        public void SendEmail(string message) => Console.WriteLine($"Email sent: {message}");
        public void SendSMS(string message) => Console.WriteLine($"SMS sent: {message}");

    } //пропозиція програми, яку я повторила



}
