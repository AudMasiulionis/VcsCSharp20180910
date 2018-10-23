using Lesson15_ValueTypes;
using Lesson19_EventsAndGenerics.Events;
using Lesson19_EventsAndGenerics.Generics;
using System;
using System.Collections.Generic;
using System.Linq;

#pragma warning disable
namespace Lesson19_EventsAndGenerics
{
    class Program
    {
        static void Main(string[] args)
        {
            //var btn = new ButtonWithoutDelegate();
            //btn.Click();

            var btn = new Button();
            btn.OnButtonClick += Btn_OnButtonClick;

            btn.Click("ConsoleApp", new BtnClickArgs { Location = "VCS" });
        }

        private static void Btn_OnButtonClick(object sender, BtnClickArgs e)
        {
            var mailService = new MailService();
            mailService.Send();
            var crmService = new CrmService();
            crmService.Send();
        }
    }
}
