using System;

namespace Lesson19_EventsAndGenerics.Events
{
    public class ButtonWithoutDelegate
    {
        public void Click()
        {
            Console.WriteLine("Button click");

            //highly coupled code
            var mailService = new MailService();
            mailService.Send();
            var crmService = new CrmService();
            crmService.Send();
        }
    }
}
